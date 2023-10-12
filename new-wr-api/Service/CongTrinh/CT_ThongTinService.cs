using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class CT_ThongTinService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AspNetUsers> _userManager;

        public CT_ThongTinService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
        }
        public async Task<List<CT_ThongTinDto>> GetAllAsync(string? TenCT, int? IdLoaiCT, int? IdHuyen, int? IdXa, int? IdSong, int? IdLuuVuc, int? IdTieuLuuVuc, int? IdTangChuaNuoc, int IdTCCN, string? NguonNuocKT)
        {
            var query = _context.CT_ThongTin!
                .Where(ct => ct.DaXoa == false)
                .Include(ct => ct.LoaiCT)
                .Include(ct => ct.TangChuaNuoc)
                .Include(ct => ct.HangMuc!).ThenInclude(hm => hm.ThongSo)
                .Include(ct => ct.ThongSo)
                .Include(ct => ct.GiayPhep!).ThenInclude(gp => gp.ToChuc_CaNhan)
                .Include(ct => ct.GiayPhep!).ThenInclude(gp => gp.GP_TCQ)
                .OrderBy(x => x.IdLoaiCT)
                .AsQueryable();

            if (!string.IsNullOrEmpty(TenCT!.ToString()))
            {
                query = query.Where(ct => ct.TenCT!.Contains(TenCT));
            }

            if (IdLoaiCT > 0)
            {
                query = query.Where(ct => IdLoaiCT == 1 || IdLoaiCT == 2 || IdLoaiCT == 3 || IdLoaiCT == 24 ? ct.LoaiCT!.IdCha == IdLoaiCT : ct.LoaiCT!.Id == IdLoaiCT);
            }

            if (!string.IsNullOrEmpty(IdXa.ToString()))
            {
                query = query.Where(ct => ct.IdXa!.Contains(IdXa.ToString()!));
            }

            if (!string.IsNullOrEmpty(IdHuyen.ToString()))
            {
                query = query.Where(ct => ct.IdHuyen!.Contains(IdHuyen.ToString()!));
            }

            if (IdSong > 0)
            {
                query = query.Where(ct => ct.IdSong == IdSong);
            }

            if (IdLuuVuc > 0)
            {
                query = query.Where(ct => ct.IdLuuVuc == IdLuuVuc);
            }

            if (IdTieuLuuVuc > 0)
            {
                query = query.Where(ct => ct.IdTieuLuuVuc == IdTieuLuuVuc);
            }

            if (IdTangChuaNuoc > 0)
            {
                query = query.Where(ct => ct.IdTangChuaNuoc == IdTangChuaNuoc);
            }

            if (IdTCCN > 0)
            {
                query = query.Where(ct => ct.GiayPhep!.Any(gp => gp.IdTCCN == IdTCCN));
            }

            if (!string.IsNullOrEmpty(NguonNuocKT))
            {
                query = query.Where(ct => ct.NguonNuocKT!.Contains(NguonNuocKT.ToString()!));
            }


            var congtrinh = await query.ToListAsync();

            var congTrinhDtos = _mapper.Map<List<CT_ThongTinDto>>(congtrinh);

            foreach (var dto in congTrinhDtos)
            {
                dto.hangmuc = _mapper.Map<List<CT_HangMucDto>>(dto.hangmuc!.Where(x => x.DaXoa == false));

                if (!string.IsNullOrEmpty(dto.IdXa))
                {
                    dto.donvi_hanhchinh = _mapper.Map<DonViHCDto>(await _context.DonViHC!
                        .FirstOrDefaultAsync(dv => dv.IdXa == dto.IdXa));
                }

                dto.giayphep = _mapper.Map<List<GP_ThongTinDto>>(dto.giayphep!.Where(x => x.DaXoa == false));

                foreach (var dtoGP in dto.giayphep)
                {
                    var tcqIds = dtoGP.gp_tcq!.Select(x => x.IdTCQ).ToList();

                    var tcqThongTinList = await _context.TCQ_ThongTin!
                        .Where(x => tcqIds.Contains(x.Id) && x.DaXoa == false)
                        .ToListAsync();

                    dtoGP.tiencq = _mapper.Map<List<TCQ_ThongTinDto>>(tcqThongTinList);

                    dtoGP.gp_tcq = null;
                }
            }

            return congTrinhDtos;
        }

        public async Task<CT_ThongTinDto?> GetByIdAsync(int Id)
        {
            var query = _context.CT_ThongTin!
                .Where(ct => ct.Id == Id && ct.DaXoa == false)
                .Include(ct => ct.LoaiCT)
                .Include(ct => ct.HangMuc!).ThenInclude(hm => hm.ThongSo)
                .Include(ct => ct.ThongSo)
                .Include(ct => ct.GiayPhep!).ThenInclude(gp => gp.ToChuc_CaNhan)
                .Include(ct => ct.GiayPhep!).ThenInclude(gp => gp.GP_TCQ)
                .OrderBy(x => x.IdLoaiCT)
                .AsQueryable();


            var congtrinh = await query.ToListAsync();

            var congTrinhDto = _mapper.Map<CT_ThongTinDto>(congtrinh);

            congTrinhDto.hangmuc = _mapper.Map<List<CT_HangMucDto>>(congTrinhDto.hangmuc!.Where(x => x.DaXoa == false));

            if (!string.IsNullOrEmpty(congTrinhDto.IdXa))
            {
                congTrinhDto.donvi_hanhchinh = _mapper.Map<DonViHCDto>(await _context.DonViHC!
                    .FirstOrDefaultAsync(dv => dv.IdXa == congTrinhDto.IdXa));
            }

            congTrinhDto.giayphep = _mapper.Map<List<GP_ThongTinDto>>(congTrinhDto.giayphep!.Where(x => x.DaXoa == false));

            foreach (var dtoGP in congTrinhDto.giayphep)
            {
                var tcqIds = dtoGP.gp_tcq!.Select(x => x.IdTCQ).ToList();

                var tcqThongTinList = await _context.TCQ_ThongTin!
                    .Where(x => tcqIds.Contains(x.Id) && x.DaXoa == false)
                    .ToListAsync();

                dtoGP.tiencq = _mapper.Map<List<TCQ_ThongTinDto>>(tcqThongTinList);

                dtoGP.gp_tcq = null;
            }

            return congTrinhDto;
        }

        public async Task<int> SaveAsync(CT_ThongTinDto model)
        {
            int id = 0;
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);
            CT_ThongTin? item = null; // Declare item variable

            var existingItem = await _context.CT_ThongTin!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);

            if (existingItem == null || model.Id == 0)
            {
                item = _mapper.Map<CT_ThongTin>(model);
                item.DaXoa = false;
                item.ThoiGianTao = DateTime.Now;
                item.TaiKhoanTao = currentUser != null ? currentUser.UserName : null;

                _context.CT_ThongTin!.Add(item);
            }
            else
            {
                item = existingItem; // Assign existingItem to item

                _mapper.Map(model, item); // Map properties from model to item
                item.ThoiGianSua = DateTime.Now;
                item.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongTin!.Update(item);
            }

            var res = await _context.SaveChangesAsync();

            // Simplified assignment of id
            id = (int)(res > 0 ? item.Id : 0);

            return id;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.CT_ThongTin!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.CT_ThongTin!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
