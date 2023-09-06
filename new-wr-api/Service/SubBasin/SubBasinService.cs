using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class SubBasinService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public SubBasinService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<SubBasinModel>> GetAllSubBasinAsync()
        {
            var items = await _context.SubBasins!.Where(b => b.IsDeleted == false).OrderBy(b => b.Name).ToListAsync();
            return _mapper.Map<List<SubBasinModel>>(items);
        }

        public async Task<SubBasinModel?> GetSubBasinByIdAsync(int Id)
        {
            var item = await _context.SubBasins!.FindAsync(Id);
            return _mapper.Map<SubBasinModel>(item);
        }


        public async Task<bool> SaveSubBasinAsync(SubBasinModel model)
        {
            var existingItem = await _context.SubBasins!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<SubBasins>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.SubBasins!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.SubBasins!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.SubBasins!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteSubBasinAsync(SubBasinModel model)
        {
            var existingItem = await _context.SubBasins!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.SubBasins!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
