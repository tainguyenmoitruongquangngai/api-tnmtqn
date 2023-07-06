using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class ConstructionService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public ConstructionService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<ConstructionModel>> GetAllConstructionAsync()
        {
            var items = await _context.Constructions!.Where(x => x.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<ConstructionModel>>(items);
        }

        public async Task<ConstructionModel?> GetConstructionByIdAsync(int Id)
        {
            var item = await _context.Constructions!.FindAsync(Id);
            return _mapper.Map<ConstructionModel>(item);
        }


        public async Task<bool> SaveConstructionAsync(ConstructionModel model)
        {
            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Constructions>(model);
                newItem.IsDeleted = false;
                newItem.Status = true;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Constructions!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Constructions!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteConstructionAsync(ConstructionModel modle)
        {
            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == modle.Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Constructions!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
