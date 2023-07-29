using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class LicenseService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public LicenseService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<LicenseModel>> GetAllLicenseAsync()
        {
            var items = await _context!.Licenses!
                .Where(u => u.IsDeleted == false)
                .ToListAsync();

            var listItems = _mapper.Map<List<LicenseModel>>(items);

            foreach (var item in listItems)
            {
                //License.OldLicenses
                var oldLicenses = await _context!.Licenses!.Where(ol => ol.ParentId == item.Id).ToListAsync();
                item.OldLicenses = _mapper.Map<List<LicenseModel>>(oldLicenses);

                //License.Constructions
                var consIds = _context!.ConstructionLicense!.Where(x => x.LicenseId == item.Id).Select(x => x.ConstructionId).ToList();
                var cons = await _context!.Constructions!.Where(x => consIds.Contains(x.Id)).ToListAsync();
                item.Constructions = _mapper.Map<List<ConstructionModel>>(cons);                                                         

                //License.Business
                var business = await _context!.Business!.FirstOrDefaultAsync(b => b.Id == item.BusinessId && b.IsDeleted == false);
                item.Business = _mapper.Map<BusinessModel>(business);
            }

            return listItems;
        }

        public async Task<LicenseModel?> GetLicenseByIdAsync(int Id)
        {
            var item = await _context.Licenses!.FindAsync(Id);
            return _mapper.Map<LicenseModel>(item);
        }


        public async Task<bool> SaveLicenseAsync(LicenseModel model)
        {
            var existingItem = await _context.Licenses!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Licenses>(model);
                newItem.IsDeleted = false;
                newItem.Status = true;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.Licenses!.Add(newItem);
            }
            else
            {
                existingItem = _mapper.Map(model, existingItem);
                existingItem!.ModifiedTime = DateTime.Now;
                existingItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.Licenses!.Update(existingItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteLicenseAsync(LicenseModel modle)
        {
            var existingItem = await _context.Licenses!.FirstOrDefaultAsync(d => d.Id == modle.Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Licenses!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
