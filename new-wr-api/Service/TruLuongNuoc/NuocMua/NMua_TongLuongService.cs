using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using System.Security.Claims;

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
        public async Task<List<TLN_NuocMua_TongLuongDto>> GetAllAsync()
        {
            var items = await _context.TLN_NuocMua_TongLuong!.Where(d => d.DaXoa == false).OrderBy(d => d.Id ).ToListAsync();
            return _mapper.Map<List<TLN_NuocMua_TongLuongDto>>(items);
        }
        public async Task<bool> SaveAsync(TLN_NuocMua_TongLuongDto dto)
        {

            var existingItem = await _context.TLN_NuocMua_TongLuong!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<TLN_NuocMua_TongLuong>(dto);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.TLN_NuocMua_TongLuong!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.TLN_NuocMua_TongLuong!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.TLN_NuocMua_TongLuong!.Update(updateItem);
            }

            var res = await _context.SaveChangesAsync();

            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.TLN_NuocMua_TongLuong!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.TLN_NuocMua_TongLuong!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
