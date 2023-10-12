using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class CT_ThongSoService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public CT_ThongSoService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<bool> SaveAsync(CT_ThongSoDto dto)
        {

            var existingItem = await _context.CT_ThongSo!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<CT_ThongSo>(dto);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.CT_ThongSo!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.CT_ThongSo!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);

                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.CT_ThongSo!.Update(updateItem);
            }

            var res = await _context.SaveChangesAsync();

            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.CT_ThongSo!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.CT_ThongSo!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
