using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using System.Linq;

namespace new_wr_api.Service
{
    public class GP_ThongTinService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AspNetUsers> _userManager;

        public GP_ThongTinService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
        }
        public async Task<List<GP_ThongTinDto>> GetAllAsync(string? SoGP, int? IdTCCN, int? IdCT, int? IdLoaiGP, int? IdLoaiCT, string? HieuLucGP)
        {
            var query = _context.GP_ThongTin!
                .Where(gp => gp.DaXoa == false)
                .Include(gp => gp.LoaiGP)
                .Include(gp => gp.ToChuc_CaNhan)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.HangMuc!).ThenInclude(hm => hm!.ThongSo)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.ThongSo)
                .Include(gp => gp.GP_TCQ)
                .OrderBy(x => x.NgayKy)
                .AsQueryable();

            if (!string.IsNullOrEmpty(SoGP))
            {
                query = query.Where(x => x.SoGP!.Contains(SoGP));
            }

            if (IdTCCN > 0)
            {
                query = query.Where(x => x.IdTCCN == IdTCCN);
            }

            if (IdCT > 0)
            {
                query = query.Where(x => x.IdCT == IdCT);
            }

            if (IdLoaiGP > 0)
            {
                query = query.Where(x => x.IdLoaiGP == IdLoaiGP);
            }

            if (IdLoaiCT > 0)
            {
                if (IdLoaiCT > 0)
                {
                    query = query.Where(gp => IdLoaiCT == 1 || IdLoaiCT == 2 || IdLoaiCT == 3 || IdLoaiCT == 24 ? gp.CongTrinh!.LoaiCT!.IdCha == IdLoaiCT : gp.CongTrinh!.LoaiCT!.Id == IdLoaiCT);
                }
            }

            if (!string.IsNullOrEmpty(HieuLucGP))
            {
                switch (HieuLucGP.ToLower())
                {
                    case "sap-het-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc >= DateTime.Today &&
                                        x.NgayHetHieuLuc < DateTime.Today.AddDays(160) &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "het-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc < DateTime.Today &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "con-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc > DateTime.Today.AddDays(160) &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "da-bi-thu-hoi":
                        query = query.Where(x => x.DaBiThuHoi == true);
                        break;
                    default: break;
                }
            }

            var giayphep = await query.ToListAsync();

            var giayPhepDtos = _mapper.Map<List<GP_ThongTinDto>>(giayphep);

            foreach (var dto in giayPhepDtos)
            {
                dto.congtrinh!.donvi_hanhchinh = _mapper.Map<DonViHCDto>(_context.DonViHC!.FirstOrDefault(x => x.IdXa!.Contains(dto.congtrinh.IdXa!)));

                // Assuming this code is within an async method
                var tcqIds = dto.gp_tcq!.Select(x => x.IdTCQ).ToList();

                var tcqThongTinList = await _context.TCQ_ThongTin!
                    .Where(x => tcqIds.Contains(x.Id) && x.DaXoa == false)
                    .ToListAsync();

                dto.tiencq = _mapper.Map<List<TCQ_ThongTinDto>>(tcqThongTinList);

                dto.gp_tcq = null;
            }

            return giayPhepDtos;
        }

        public async Task<GP_ThongTinDto> GetByIdAsync(int Id)
        {
            var query = _context.GP_ThongTin!
                .Where(gp => gp.Id == Id && gp.DaXoa == false)
                .Include(gp => gp.LoaiGP)
                .Include(gp => gp.ToChuc_CaNhan)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.HangMuc!).ThenInclude(hm => hm!.ThongSo)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.ThongSo)
                .Include(gp => gp.GP_TCQ)
                .OrderBy(x => x.NgayKy)
                .AsQueryable();

            var giayphep = await query.FirstOrDefaultAsync();

            var giayPhepDto = _mapper.Map<GP_ThongTinDto>(giayphep);
            giayPhepDto.congtrinh!.donvi_hanhchinh = _mapper.Map<DonViHCDto>(_context.DonViHC!.FirstOrDefault(x => x.IdXa!.Contains(giayPhepDto.congtrinh.IdXa!)));

            // Assuming this code is within an async method
            var tcqIds = giayPhepDto.gp_tcq!.Select(x => x.IdTCQ).ToList();

            var tcqThongTinList = await _context.TCQ_ThongTin!
                .Where(x => tcqIds.Contains(x.Id) && x.DaXoa == false)
                .ToListAsync();

            giayPhepDto.tiencq = _mapper.Map<List<TCQ_ThongTinDto>>(tcqThongTinList);

            giayPhepDto.gp_tcq = null;

            return giayPhepDto;
        }

        public async Task<int> SaveAsync(GP_ThongTinDto model)
        {
            int id = 0;
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);
            GP_ThongTin? item = null; // Declare item variable

            var existingItem = await _context.GP_ThongTin!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);

            if (existingItem == null || model.Id == 0)
            {
                item = _mapper.Map<GP_ThongTin>(model);
                item.DaXoa = false;
                item.ThoiGianTao = DateTime.Now;
                item.TaiKhoanTao = currentUser != null ? currentUser.UserName : null;

                _context.GP_ThongTin!.Add(item);
            }
            else
            {
                item = existingItem; // Assign existingItem to item

                _mapper.Map(model, item); // Map properties from model to item
                item.ThoiGianSua = DateTime.Now;
                item.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.GP_ThongTin!.Update(item);
            }

            var res = await _context.SaveChangesAsync();

            // Simplified assignment of id
            id = (int)(res > 0 ? item.Id : 0);

            return id;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.GP_ThongTin!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.GP_ThongTin!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
