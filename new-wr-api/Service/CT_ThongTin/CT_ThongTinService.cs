using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using System.Linq;

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
        public async Task<List<CT_ThongTinDto>> GetAllAsync(int? IdLoaiCT, string? IdHuyen, string? IdXa, int? IdSong, int? IdLuuVuc, int? IdTieuLuuVuc, int? IdTangChuaNuoc, int IdTCCN)
        {
            var query = _context.CT_ThongTin!
                .Include(ct => ct.LoaiCT)
                .Include(ct => ct.HangMuc!).ThenInclude(hm => hm.ThongSo)
                .Include(ct => ct.ThongSo)
                .Include(ct => ct.GiayPhep!).ThenInclude(tc => tc.ToChuc_CaNhan)
                .Where(ct => ct.DaXoa == false && ct.LoaiCT!.DaXoa == false && ct.HangMuc!.Any(hm => hm.DaXoa == false) == false && ct.ThongSo!.DaXoa == false && ct.GiayPhep!.Any(gp => gp.DaXoa == false))
                .OrderBy(x => x.IdLoaiCT)
                .AsQueryable();


            if (IdLoaiCT > 0)
            {
                query = query.Where(ct => IdLoaiCT == 1 || IdLoaiCT == 2 || IdLoaiCT == 3 || IdLoaiCT == 24 ? ct.LoaiCT!.IdCha == IdLoaiCT : ct.LoaiCT!.Id == IdLoaiCT);
            }

            if (!string.IsNullOrEmpty(IdXa))
            {
                query = query.Where(ct => ct.IdXa!.Contains(IdXa.ToString()!));
            }

            if (!string.IsNullOrEmpty(IdHuyen))
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


            var congtrinh = await query.ToListAsync();

            var congTrinhDtos = _mapper.Map<List<CT_ThongTinDto>>(congtrinh);

            foreach (var dto in congTrinhDtos)
            {
                dto.hangmuc = _mapper.Map<List<CT_HangMucDto>>(dto.hangmuc);

                dto.loaiCT = _mapper.Map<CT_LoaiDto>(dto.loaiCT);

                if (!string.IsNullOrEmpty(dto.IdXa))
                {
                    dto.donvi_hanhchinh = _mapper.Map<DonViHCDto>(await _context.DonViHC!
                        .FirstOrDefaultAsync(dv => dv.IdXa == dto.IdXa));
                }

                foreach (var dtoHM in dto.hangmuc)
                {
                    dtoHM.thongso = _mapper.Map<CT_ThongSoDto>(dtoHM.thongso);
                }

                dto.thongso = _mapper.Map<CT_ThongSoDto>(dto.thongso);

                dto.giayphep = _mapper.Map<List<GP_ThongTinDto>>(dto.giayphep);

                foreach (var dtoGP in dto.giayphep)
                {
                    dtoGP.tochuc_canhan = _mapper.Map<ToChuc_CaNhanDto>(dtoGP.tochuc_canhan);
                }
            }

            return congTrinhDtos;
        }

        public async Task<CT_ThongTinDto?> GetByIdAsync(int Id)
        {
            var query = _context.CT_ThongTin!
                .Include(ct => ct.LoaiCT)
                .Include(ct => ct.HangMuc!).ThenInclude(hm => hm.ThongSo)
                .Include(ct => ct.ThongSo)
                .Include(ct => ct.GiayPhep!).ThenInclude(tc => tc.ToChuc_CaNhan)
                .AsQueryable();

            var congtrinh = await query.FirstOrDefaultAsync(x => x.Id == Id);

            var CT_Dto = _mapper.Map<CT_ThongTinDto>(congtrinh);

            CT_Dto.hangmuc = _mapper.Map<List<CT_HangMucDto>>(CT_Dto.hangmuc);

            CT_Dto.loaiCT = _mapper.Map<CT_LoaiDto>(CT_Dto.loaiCT);

            if (!string.IsNullOrEmpty(CT_Dto.IdXa))
            {
                CT_Dto.donvi_hanhchinh = _mapper.Map<DonViHCDto>(await _context.DonViHC!
                    .FirstOrDefaultAsync(dv => dv.IdXa == CT_Dto.IdXa));
            }

            foreach (var dtoHM in CT_Dto.hangmuc)
            {
                dtoHM.thongso = _mapper.Map<CT_ThongSoDto>(dtoHM.thongso);
            }

            CT_Dto.thongso = _mapper.Map<CT_ThongSoDto>(CT_Dto.thongso);

            CT_Dto.giayphep = _mapper.Map<List<GP_ThongTinDto>>(CT_Dto.giayphep);

            foreach (var dtoGP in CT_Dto.giayphep)
            {
                dtoGP.tochuc_canhan = _mapper.Map<ToChuc_CaNhanDto>(dtoGP.tochuc_canhan);
            }
            return CT_Dto;
        }

        public async Task<int> SaveAsync(CT_ThongTinDto model)
        {
            int id = 0;
            //Notification? notify = new Notification();
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);
            CT_ThongTin? item = null; // Declare item variable

            var existingItem = await _context.CT_ThongTin!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);

            if (existingItem == null || model.Id == 0)
            {
                item = _mapper.Map<CT_ThongTin>(model);
                item.DaXoa = false;
                item.ThoiGianTao = DateTime.Now;
                item.TaiKhoan = currentUser != null ? currentUser.UserName : null;

                _context.CT_ThongTin!.Add(item);

                // Notification
                //notify.NotifyTitle = "Giấy phép: " + item.LicenseNumber;
                //notify.NotifyContent = "Tài khoản " + currentUser!.UserName + " đã thêm 1 bản ghi: " + item.LicenseNumber;
            }
            else
            {
                item = existingItem; // Assign existingItem to item

                _mapper.Map(model, item); // Map properties from model to item
                item.ThoiGianSua = DateTime.Now;
                item.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongTin!.Update(item);

                // Notification
                //notify.NotifyTitle = "Giấy phép: " + item.LicenseNumber;
                //notify.NotifyContent = "Tài khoản " + currentUser!.UserName + " đã sửa 1 bản ghi: " + item.LicenseNumber;
            }

            //var cons = await _context.Constructions!.FirstOrDefaultAsync(c => c.Id == item.ConstructionId);
            //notify.Url = "/giay-phep/" + GetUrl((int)(cons?.ConstructionParentTypeId != 2 ? cons?.ConstructionParentTypeId! : cons.ConstructionTypeId!)) + "?licenseNumber=" + item.LicenseNumber;
            //notify.Time = DateTime.Now;
            //_context.Notification!.Add(notify);

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
