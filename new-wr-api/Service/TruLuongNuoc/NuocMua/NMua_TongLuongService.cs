using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace new_wr_api.Service
{
    public class NMua_TongLuongService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public NMua_TongLuongService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }
        public async Task<List<KKTNN_NuocMua_TongLuongDto>> GetAllAsync()
        {
            var items = await _context.KKTNN_NuocMua_TongLuong!.Where(d => d.DaXoa == false)
                .Include(d => d.Tram_ThongTin)
                .OrderBy(d => d.Id)
                .AsQueryable().ToListAsync();

            var tongLuongNuocMuaDto = _mapper.Map<List<KKTNN_NuocMua_TongLuongDto>>(items);
            foreach (var dto in tongLuongNuocMuaDto)
            {
                if (!string.IsNullOrEmpty(dto.Tram!.IdXa.ToString()))
                {
                    dto.donvi_hanhchinh = _mapper.Map<DonViHCDto>(await _context.DonViHC!
                        .FirstOrDefaultAsync(dv => dv.IdXa == dto.Tram!.IdXa.ToString()));
                }
            }
            return tongLuongNuocMuaDto;

            
        }
        public async Task<bool> SaveAsync(KKTNN_NuocMua_TongLuongDto dto)
        {

            var existingItem = await _context.KKTNN_NuocMua_TongLuong!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<KKTNN_NuocMua_TongLuong>(dto);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.KKTNN_NuocMua_TongLuong!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.KKTNN_NuocMua_TongLuong!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.KKTNN_NuocMua_TongLuong!.Update(updateItem);
            }

            var res = await _context.SaveChangesAsync();

            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.KKTNN_NuocMua_TongLuong!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.KKTNN_NuocMua_TongLuong!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
