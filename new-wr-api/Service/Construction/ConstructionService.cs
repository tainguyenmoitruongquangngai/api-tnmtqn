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
            var items = await _context.Constructions!
                                     .Where(x => x.IsDeleted == false)
                                     .OrderBy(x => x.ConstructionName)
                                     .ToListAsync();

            var listItems = _mapper.Map<List<ConstructionModel>>(items);

            foreach (var item in listItems)
            {
                var consTypes = await _context!.ConstructionTypes!
                                            .FirstOrDefaultAsync(ct => ct.Id == item.ConstructionTypeId);

                item.ConstructionTypeName = consTypes?.TypeName;

                item.ConstructionTypeSlug = consTypes?.TypeSlug;


                var location = _context.Locations?
                   .Where(l => l.DistrictId == item.DistrictId.ToString() && l.CommuneId == item.CommuneId.ToString()).FirstOrDefault();

                item.DistrictName = location?.DistrictName;
                item.CommuneName = location?.CommuneName;

                item.RiverName = _context.Rivers?
                    .Where(r => r.Id == item.RiverId)
                    .Select(r => r.Name).FirstOrDefault();

                item.BasinName = _context.Basins?
                    .Where(b => b.Id == item.BasinId)
                    .Select(b => b.Name).FirstOrDefault();

                item.SubBasinName = _context.SubBasins?
                    .Where(sb => sb.Id == item.SubBasinId)
                    .Select(sb => sb.Name).FirstOrDefault();

                //get list license
                var licenses = await _context!.Licenses!.Where(l => l.ConstructionId == item.Id).ToListAsync();

                item.Licenses = _mapper.Map<List<LicenseModel>>(licenses);
                if (item.Licenses != null)
                {
                    //get license fee
                    foreach (var lic in item.Licenses)
                    {
                        var licLicfeeIds = await _context.LicenseLicenseFee!
                                            .Where(llf => llf.LicenseId == lic.Id)
                                            .Select(llf => llf.LicenseFeeId)
                                            .ToListAsync();

                        var licenseFees = await _context!.LicenseFees!
                                            .Where(lc => licLicfeeIds.Contains(lc.Id))
                                            .ToListAsync();

                        lic.LicenseFees = _mapper.Map<List<LicenseFeeModel>>(licenseFees);
                    }
                }

                //list construction items
                var consItems = await _context!.ConstructionDetails!
                                              .Where(ci => ci.ConstructionId == item.Id)
                                              .ToListAsync();
                item.ConstructionItems = _mapper.Map<List<ConstructionDetailModel>>(consItems);
            }

            return listItems;
        }


        public async Task<ConstructionModel?> GetConstructionByIdAsync(int Id)
        {
            var item = await _context.Constructions!.FindAsync(Id);
            return _mapper.Map<ConstructionModel>(item);
        }


        public async Task<int> SaveConstructionAsync(ConstructionModel model)
        {
            var id = 0;
            Constructions? newItem = null;

            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                newItem = _mapper.Map<Constructions>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.Constructions!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.Constructions!.Update(updateItem);
            }

            var res = await _context.SaveChangesAsync();
            if (res == 1)
            {
                if (newItem != null)
                {
                    id = newItem.Id;
                }
                else
                {
                    id = model.Id;
                }
            }
            else
            {
                id = 0;
            }

            return id;
        }


        public async Task<bool> DeleteConstructionAsync(ConstructionModel model)
        {
            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Constructions!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
