using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class LicenseTypesService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public LicenseTypesService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<LicenseTypesModel>> GetAllLicenseTypesAsync()
        {
            var items = await _context.LicenseTypes!.Where(x => x.IsDeleted == false).OrderBy(x => x.TypeName).ToListAsync();
            return _mapper.Map<List<LicenseTypesModel>>(items);
        }

        public async Task<LicenseTypesModel?> GetLicenseTypesByIdAsync(int Id)
        {
            var item = await _context.LicenseTypes!.FindAsync(Id);
            return _mapper.Map<LicenseTypesModel>(item);
        }


        public async Task<bool> SaveLicenseTypesAsync(LicenseTypesModel model)
        {
            var existingItem = await _context.LicenseTypes!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<LicenseTypes>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.LicenseTypes!.Add(newItem);
            }
            else
            {
                existingItem = _mapper.Map(model, existingItem);
                existingItem!.ModifiedTime = DateTime.Now;
                existingItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.LicenseTypes!.Update(existingItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteLicenseTypesAsync(int Id)
        {
            var existingItem = await _context.LicenseTypes!.FirstOrDefaultAsync(d => d.Id == Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.LicenseTypes!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
