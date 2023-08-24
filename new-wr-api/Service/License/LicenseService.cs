using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
                .Where(x => x.IsDeleted == false).OrderByDescending(x => x.SignDate)
                .ToListAsync();

            var listItems = _mapper.Map<List<LicenseModel>>(items);

            foreach (var item in listItems)
            {
                //License.OldLicense
                var oldLicense = await _context!.Licenses!.FirstOrDefaultAsync(ol => ol.Id == item.ChildId);
                item.OldLicense = _mapper.Map<LicenseModel>(oldLicense);

                //License.Construction
                var cons = await _context!.Constructions!.FirstOrDefaultAsync(x => x.Id == item.ConstructionId);
                item.Construction = _mapper.Map<ConstructionModel>(cons);

                //License.LicenseFees
                var licFeeIds = _context!.LicenseLicenseFee!.Where(x => x.LicenseId == item.Id).Select(x => x.LicenseFeeId).ToList();
                var licFee = await _context!.LicenseFees!.Where(x => licFeeIds.Contains(x.Id) && x.IsDeleted == false).ToListAsync();
                item.LicenseFees = _mapper.Map<List<LicenseFeeModel>>(licFee);

                //License.Business
                var business = await _context!.Business!.FirstOrDefaultAsync(b => b.Id == item.BusinessId && b.IsDeleted == false);
                item.Business = _mapper.Map<BusinessModel>(business);

                //For fillter
                if (item.IsRevoked == true)
                {
                    item.LicenseValidity = "da-bi-thu-hoi";
                }
                else if (item.ExpriteDate.HasValue)
                {
                    DateTime expireDate = item.ExpriteDate.Value; // Convert nullable DateTime? to non-nullable DateTime
                    if (expireDate >= DateTime.Today && expireDate < DateTime.Today.AddDays(160))
                    {
                        item.LicenseValidity = "sap-het-hieu-luc";
                    }
                    else if (expireDate < DateTime.Today)
                    {
                        item.LicenseValidity = "het-hieu-luc";
                    }
                    else if (expireDate > DateTime.Today.AddDays(160))
                    {
                        item.LicenseValidity = "con-hieu-luc";
                    }
                }
                else
                {
                    item.LicenseValidity = "con-hieu-luc";
                }

                var licTypes = await _context!.LicenseTypes!.FirstOrDefaultAsync(l => l.Id == item.LicensingTypeId);
                item.LicenseTypeName = licTypes?.TypeName;
                item.LicenseTypeSlug = licTypes?.TypeSlug;

                if (cons != null)
                {
                    var consTypes = await _context!.ConstructionTypes!.FirstOrDefaultAsync(l => l.Id == cons.ConstructionTypeId);
                    item.ConstructionTypeSlug = consTypes?.TypeSlug;
                    item.Construction.ConstructionTypeName = consTypes?.TypeName;
                    item.ConstructionName = cons.ConstructionName;
                    item.CommuneId = cons.CommuneId;
                    item.DistrictId = cons.DistrictId;
                    item.BasinId = cons.BasinId;

                    var location = _context.Locations?
                   .Where(l => l.DistrictId == item.DistrictId.ToString() && l.CommuneId == item.CommuneId.ToString()).FirstOrDefault();

                    item.Construction.DistrictName = location?.DistrictName;
                    item.Construction.CommuneName = location?.CommuneName;

                    item.Construction.RiverName = _context.Rivers?
                        .Where(r => r.Id == cons.RiverId)
                        .Select(r => r.Name).FirstOrDefault();

                    item.Construction.BasinName = _context.Basins?
                        .Where(b => b.Id == cons.BasinId)
                        .Select(b => b.Name).FirstOrDefault();

                    item.Construction.SubBasinName = _context.SubBasins?
                        .Where(sb => sb.Id == cons.SubBasinId)
                        .Select(sb => sb.Name).FirstOrDefault();
                }
            }

            return listItems;
        }

        public async Task<LicenseModel?> GetLicenseByIdAsync(int Id)
        {
            var item = await _context.Licenses!.FindAsync(Id);
            return _mapper.Map<LicenseModel>(item);
        }


        public async Task<int> SaveLicenseAsync(LicenseModel model)
        {
            var id = 0;
            Licenses? newItem = null;

            var existingItem = await _context.Licenses!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                newItem = _mapper.Map<Licenses>(model);
                newItem.IsDeleted = false;
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
