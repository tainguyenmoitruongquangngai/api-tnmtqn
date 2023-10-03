using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class RiverService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public RiverService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<RiverModel>> GetAllRiverAsync()
        {
            var items = await _context.Rivers!.Where(x => x.IsDeleted == false).OrderBy(x => x.Name).ToListAsync();

            var listItems = _mapper.Map<List<RiverModel>>(items);

            foreach (var item in listItems)
            {
                //River.Basin
                var basin = await _context!.Basins!.FirstOrDefaultAsync(b => b.Id == item.BasinId && b.IsDeleted == false);
                item.Basin = _mapper.Map<BasinModel>(basin);
                //River.Location
                var location = await _context!.Locations!.FirstOrDefaultAsync(l => l.Id == item.LocationId && l.IsDeleted == false);
                item.Location = _mapper.Map<LocationsModel>(location);
            }

            return listItems;
        }

        public async Task<RiverModel?> GetRiverByIdAsync(int Id)
        {
            var item = await _context.Rivers!.FindAsync(Id);
            return _mapper.Map<RiverModel>(item);
        }


        public async Task<bool> SaveRiverAsync(RiverModel model)
        {
            var existingItem = await _context.Rivers!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Rivers>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Rivers!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Rivers!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Rivers!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteRiverAsync(int Id)
        {
            var existingItem = await _context.Rivers!.FirstOrDefaultAsync(d => d.Id == Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Rivers!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
