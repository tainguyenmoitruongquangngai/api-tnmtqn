using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.BC.KNTiepNhanNuocThai.KNTNNTSong;
using new_wr_api.Dto;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class PhanDoanSongService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public PhanDoanSongService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<PhanDoanSongDto>> GetAllAsync()
        {
            var items = await _context.PhanDoanSong!.Where(b => b.DaXoa == false)
                .ToListAsync();
            return _mapper.Map<List<PhanDoanSongDto>>(items);
        }

        public async Task<PhanDoanSongDto?> GetByIdAsync(int Id)
        {
            var item = await _context.PhanDoanSong!.FindAsync(Id);
            return _mapper.Map<PhanDoanSongDto>(item);
        }


        public async Task<bool> SaveAsync(PhanDoanSongDto dto)
        {
            var existingItem = await _context.PhanDoanSong!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<PhanDoanSong>(dto);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.PhanDoanSong!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.PhanDoanSong!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

                updateItem = _mapper.Map(dto, updateItem);

                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.PhanDoanSong!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.PhanDoanSong!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.PhanDoanSong!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
