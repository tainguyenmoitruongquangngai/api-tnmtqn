using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class GP_LoaiService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public GP_LoaiService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<GP_LoaiDto>> GetAllAsync()
        {
            var items = await _context.GP_Loai!.Where(x => x.DaXoa == false).OrderBy(x => x.TenLoaiGP).ToListAsync();
            return _mapper.Map<List<GP_LoaiDto>>(items);
        }

        public async Task<GP_LoaiDto?> GetGP_LoaiByIdAsync(int Id)
        {
            var item = await _context.GP_Loai!.FindAsync(Id);
            return _mapper.Map<GP_LoaiDto>(item);
        }

        public async Task<bool> SaveAsync(GP_LoaiDto dto)
        {
            var existingItem = await _context.GP_Loai!.FirstOrDefaultAsync(d => d.Id == dto.Id);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<GP_Loai>(dto);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.GP_Loai!.Add(newItem);
            }
            else
            {
                existingItem = _mapper.Map(dto, existingItem);
                existingItem!.ThoiGianSua = DateTime.Now;
                existingItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.GP_Loai!.Update(existingItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.GP_Loai!.FirstOrDefaultAsync(d => d.Id == Id);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.GP_Loai!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
