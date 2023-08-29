using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class ConstructionTypesService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public ConstructionTypesService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<ConstructionTypesModel>> GetAllConstructionTypesAsync()
        {
            var items = await _context.ConstructionTypes!.Where(x => x.IsDeleted == false).OrderBy(x => x.TypeName).ToListAsync();
            return _mapper.Map<List<ConstructionTypesModel>>(items);
        }

        public async Task<ConstructionTypesModel?> GetConstructionTypesByIdAsync(int Id)
        {
            var item = await _context.ConstructionTypes!.FindAsync(Id);
            return _mapper.Map<ConstructionTypesModel>(item);
        }


        public async Task<bool> SaveConstructionTypesAsync(ConstructionTypesModel model)
        {
            var existingItem = await _context.ConstructionTypes!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<ConstructionTypes>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.ConstructionTypes!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.ConstructionTypes!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.ConstructionTypes!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteConstructionTypesAsync(ConstructionTypesModel model)
        {
            var existingItem = await _context.ConstructionTypes!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.ConstructionTypes!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
