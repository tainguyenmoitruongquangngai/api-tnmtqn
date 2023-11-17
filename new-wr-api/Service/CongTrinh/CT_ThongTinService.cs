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

        // Constructor to initialize the service with required dependencies
        public CT_ThongTinService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
        }

        // Method to retrieve a list of CT_ThongTin entities based on specified filters
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
                .Include(ct => ct.LuuLuongTheoMucDich)
                .OrderBy(x => x.IdLoaiCT)
                .AsQueryable();

            // Apply filters based on input parameters
            if (!string.IsNullOrEmpty(TenCT))
            {
                query = query.Where(ct => ct.TenCT!.Contains(TenCT));
            }

            if (IdLoaiCT > 0)
            {
                query = query.Where(ct => IdLoaiCT == 1 || IdLoaiCT == 2 || IdLoaiCT == 3 || IdLoaiCT == 24 ? ct.LoaiCT!.IdCha == IdLoaiCT : ct.LoaiCT!.Id == IdLoaiCT);
            }

            if (IdXa > 0)
            {
                query = query.Where(ct => ct.IdXa!.Contains(IdXa.ToString()!));
            }

            if (IdHuyen > 0)
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
                query = query.Where(ct => ct.NguonNuocKT!.Contains(NguonNuocKT));
            }

            var congtrinh = await query.ToListAsync();

            // Map the result to DTOs
            var congTrinhDtos = _mapper.Map<List<CT_ThongTinDto>>(congtrinh);

            // Further processing on DTOs
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

            // Return the list of DTOs
            return congTrinhDtos;
        }

        // Method to retrieve a single CT_ThongTin entity by Id
        public async Task<CT_ThongTinDto?> GetByIdAsync(int Id)
        {
            var query = _context.CT_ThongTin!
                .Where(ct => ct.DaXoa == false && ct.Id == Id)
                .Include(ct => ct.LoaiCT)
                .Include(ct => ct.TangChuaNuoc)
                .Include(ct => ct.HangMuc!).ThenInclude(hm => hm.ThongSo)
                .Include(ct => ct.ThongSo)
                .Include(ct => ct.GiayPhep!).ThenInclude(gp => gp.ToChuc_CaNhan)
                .Include(ct => ct.GiayPhep!).ThenInclude(gp => gp.GP_TCQ)
                .OrderBy(x => x.IdLoaiCT)
                .AsQueryable();

            var congtrinh = query.FirstOrDefault();

            // Map the result to a DTO
            var congTrinhDto = _mapper.Map<CT_ThongTinDto>(query);

            // Further processing on the DTO
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

            // Return the DTO
            return congTrinhDto;
        }

        // Method to save or update a CT_ThongTin entity
        public async Task<int> SaveAsync(CT_ThongTinDto dto)
        {
            int id = 0;
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);
            CT_ThongTin? item = null; // Declare item variable

            // Retrieve an existing item based on Id or if dto.Id is 0
            var existingItem = await _context.CT_ThongTin!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                // If the item doesn't exist or dto.Id is 0, create a new item
                item = _mapper.Map<CT_ThongTin>(dto);
                item.DaXoa = false;
                item.ThoiGianTao = DateTime.Now;
                item.TaiKhoanTao = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongTin!.Add(item);
            }
            else
            {
                // If the item exists, update it with values from the dto
                item = existingItem;
                _mapper.Map(dto, item);
                item.DaXoa = false;
                item.ThoiGianSua = DateTime.Now;
                item.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongTin!.Update(item);
            }

            // Save changes to the database
            var res = await _context.SaveChangesAsync();

            // Simplified assignment of id based on the result of SaveChanges
            id = (int)(res > 0 ? item.Id : 0);

            // Return the id
            return id;
        }

        // Method to delete a CT_ThongTin entity
        public async Task<bool> DeleteAsync(int Id)
        {
            // Retrieve an existing item based on Id
            var existingItem = await _context.CT_ThongTin!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);

            if (existingItem == null) { return false; } // If the item doesn't exist, return false

            existingItem!.DaXoa = true; // Mark the item as deleted
            existingItem.ThoiGianSua = DateTime.Now;
            existingItem.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
            _context.CT_ThongTin!.Update(existingItem);

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Return true to indicate successful deletion
            return true;
        }
    }
}
