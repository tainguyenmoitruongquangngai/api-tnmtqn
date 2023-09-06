using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class AquiferService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public AquiferService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<AquiferModel>> GetAllAquiferAsync()
        {
            var items = await _context.Aquifers!.Where(b => b.IsDeleted == false).OrderBy(b => b.Name).ToListAsync();
            return _mapper.Map<List<AquiferModel>>(items);
        }

        public async Task<AquiferModel?> GetAquiferByIdAsync(int Id)
        {
            var item = await _context.Aquifers!.FindAsync(Id);
            return _mapper.Map<AquiferModel>(item);
        }


        public async Task<bool> SaveAquiferAsync(AquiferModel model)
        {
            var existingItem = await _context.Aquifers!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Aquifers>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Aquifers!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Aquifers!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Aquifers!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteAquiferAsync(AquiferModel model)
        {
            var existingItem = await _context.Aquifers!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Aquifers!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}