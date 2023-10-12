using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class CT_LoaiService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public CT_LoaiService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<CT_LoaiDto>> GetAllAsync()
        {
            var items = await _context.CT_Loai!.Where(x => x.DaXoa == false).OrderBy(x => x.Id).ToListAsync();
            return _mapper.Map<List<CT_LoaiDto>>(items);
        }

        public async Task<CT_LoaiDto?> GetByIdAsync(int Id)
        {
            var item = await _context.CT_Loai!.FindAsync(Id);
            return _mapper.Map<CT_LoaiDto>(item);
        }


        public async Task<bool> SaveAsync(CT_LoaiDto dto)
        {
            var existingItem = await _context.CT_Loai!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<CT_Loai>(dto);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.CT_Loai!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.CT_Loai!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

                updateItem = _mapper.Map(dto, updateItem);

                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.CT_Loai!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.CT_Loai!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.CT_Loai!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
