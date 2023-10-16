using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class ToChucCaNhanService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public ToChucCaNhanService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<ToChuc_CaNhanDto>> GetAllAsync()
        {
            var items = await _context.ToChuc_CaNhan!.Where(x => x.DaXoa == false).OrderBy(x => x.TenTCCN).ToListAsync();
            return _mapper.Map<List<ToChuc_CaNhanDto>>(items);
        }

        public async Task<ToChuc_CaNhanDto?> GetByIdAsync(int Id)
        {
            var item = await _context.ToChuc_CaNhan!.FindAsync(Id);
            return _mapper.Map<ToChuc_CaNhanDto>(item);
        }

        public async Task<bool> SaveAsync(ToChuc_CaNhanDto model)
        {
            var existingItem = await _context.ToChuc_CaNhan!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<ToChuc_CaNhan>(model);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.ToChuc_CaNhan!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.ToChuc_CaNhan!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.ToChuc_CaNhan!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.ToChuc_CaNhan!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.ToChuc_CaNhan!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
