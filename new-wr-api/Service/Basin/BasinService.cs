using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class BasinService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public BasinService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<BasinModel>> GetAllBasinAsync()
        {
            var items = await _context.Basins!.Where(b => b.IsDeleted == false).OrderBy(b => b.Name).ToListAsync();
            return _mapper.Map<List<BasinModel>>(items);
        }

        public async Task<BasinModel?> GetBasinByIdAsync(int Id)
        {
            var item = await _context.Basins!.FindAsync(Id);
            return _mapper.Map<BasinModel>(item);
        }


        public async Task<bool> SaveBasinAsync(BasinModel model)
        {
            var existingItem = await _context.Basins!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Basins>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Basins!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Basins!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Basins!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBasinAsync(BasinModel model)
        {
            var existingItem = await _context.Basins!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Basins!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
