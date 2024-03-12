using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.BC.KNTiepNhanNuocThai.KNTNNTSong;
using new_wr_api.Dto;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class DuLieuNguonNuocThaiDiemService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public DuLieuNguonNuocThaiDiemService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<DuLieuNguonNuocThaiDiemDto>> GetAllAsync()
        {
            var items = await _context.DuLieuNguonNuocThaiDiem!.Where(b => b.DaXoa == false).ToListAsync();
            return _mapper.Map<List<DuLieuNguonNuocThaiDiemDto>>(items);
        }

        public async Task<DuLieuNguonNuocThaiDiemDto?> GetByIdAsync(int Id)
        {
            var item = await _context.DuLieuNguonNuocThaiDiem!.FindAsync(Id);
            return _mapper.Map<DuLieuNguonNuocThaiDiemDto>(item);
        }


        public async Task<bool> SaveAsync(DuLieuNguonNuocThaiDiemDto dto)
        {
            var existingItem = await _context.DuLieuNguonNuocThaiDiem!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<DuLieuNguonNuocThaiDiem>(dto);
                newItem.DaXoa = false;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.DuLieuNguonNuocThaiDiem!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.DuLieuNguonNuocThaiDiem!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

                updateItem = _mapper.Map(dto, updateItem);

                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.DuLieuNguonNuocThaiDiem!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.DuLieuNguonNuocThaiDiem!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.DuLieuNguonNuocThaiDiem!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
