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

        public async Task<List<ConstructionModel>> GetAllConstructionAsync(string? ConstructionName, string? ExploitedWS, int ConstructionTypeId, int BusinessId, int DistrictId, int CommuneId, int PageIndex, int PageSize)
        {
            //TRUY VẤN DỮ LIỆU
            var query = from construction in _context.Constructions
                        where construction.IsDeleted == false
                        && (string.IsNullOrEmpty(ConstructionName) || construction.ConstructionName!.ToLower().Contains(ConstructionName.ToLower()))
                        && (string.IsNullOrEmpty(ExploitedWS) || construction.ExploitedWS!.ToLower().Contains(ExploitedWS.ToLower()))
                        && (DistrictId == 0 || construction.DistrictId.ToString() == DistrictId.ToString())
                        && (CommuneId == 0 || construction.CommuneId.ToString() == CommuneId.ToString())
                        orderby construction.ConstructionName
                        select new
                        {
                            Construction = construction,
                            Licenses = _context.Licenses!
                                .Where(l => l.ConstructionId == construction.Id && l.IsDeleted == false).ToList()
                        };

            query = query
                .Where(x =>
                    (BusinessId == 0 || x.Licenses.Any(license => license.BusinessId == BusinessId)));

            if (ConstructionTypeId > 0)
            {
                List<int> TOCparrentId = new List<int>(new int[] { });
                switch (ConstructionTypeId)
                {
                    case 1:
                        TOCparrentId = new List<int>(new int[] { 4, 5, 6, 10, 11, 12, 13, 14 });
                        query = query.Where(x => TOCparrentId.Contains((int)x.Construction.ConstructionTypeId!));
                        break;
                    case 2:
                        TOCparrentId = new List<int>(new int[] { 7, 8, 9, 23 });
                        query = query.Where(x => TOCparrentId.Contains((int)x.Construction.ConstructionTypeId!));
                        break;
                    case 3:
                        TOCparrentId = new List<int>(new int[] { 16, 17, 18, 19, 20, 21, 22 });
                        query = query.Where(x => TOCparrentId.Contains((int)x.Construction.ConstructionTypeId!));
                        break;
                    case 24:
                        TOCparrentId = new List<int>(new int[] { 25 });
                        query = query.Where(x => TOCparrentId.Contains((int)x.Construction.ConstructionTypeId!));
                        break;
                    default:
                        query = query.Where(x => ConstructionTypeId == 0 || x.Construction.ConstructionTypeId == ConstructionTypeId);
                        break;
                }
            }

            if (PageSize > 0)
            {
                if (PageIndex < 1) PageIndex = 1;
                query = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            }
            var queryResults = await query.ToListAsync();

            var listItems = new List<ConstructionModel>();

            // THIẾT LẬP DỮ LIỆU KHÁC NGOÀI GIẤY PHÉP
            foreach (var queryResult in queryResults)
            {
                var constructionId = queryResult.Construction?.Id;

                var constructionModel = new ConstructionModel();

                // Ánh xạ dữ liệu Construction
                _mapper.Map(queryResult.Construction, constructionModel);

                // Ánh xạ dữ liệu License
                _mapper.Map(queryResult.Licenses, constructionModel.Licenses);

                foreach (var lic in constructionModel.Licenses!)
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

                var consItems = _mapper.Map<List<ConstructionItemModel>>(await _context!.ConstructionItems!
                              .Where(ct => ct.Id == constructionModel.ConstructionTypeId && ct.IsDeleted == false).ToListAsync());

                foreach (var constructionItemModel in consItems)
                {
                    constructionItemModel.ConstructionSpecification = _mapper.Map<ConstructionSpecificationModel>(await _context!.ConstructionSpecifications!
                                            .FirstOrDefaultAsync(ct => ct.ConstructionItemId == constructionItemModel.Id && ct.IsDeleted == false));
                }

                // Assign the modified list to constructionModel.ConstructionItems
                constructionModel.ConstructionItems = consItems;

                constructionModel.ConstructionSpecification = _mapper.Map<ConstructionSpecificationModel>(await _context!.ConstructionSpecifications!
                                              .FirstOrDefaultAsync(ci => ci.ConstructionId == constructionModel.Id && ci.IsDeleted == false));


                var consTypes = await _context!.ConstructionTypes!
                                            .FirstOrDefaultAsync(ct => ct.Id == constructionModel.ConstructionTypeId && ct.IsDeleted == false);

                constructionModel.ConstructionTypeName = consTypes?.TypeName;
                constructionModel.ConstructionTypeSlug = consTypes?.TypeSlug;

                var location = _context.Locations?
                           .Where(l => l.DistrictId == constructionModel.DistrictId.ToString() && l.CommuneId == constructionModel.CommuneId.ToString() && l.IsDeleted == false).FirstOrDefault();

                constructionModel.DistrictName = location?.DistrictName;
                constructionModel.CommuneName = location?.CommuneName;

                constructionModel.RiverName = _context.Rivers?
                    .Where(r => r.Id == constructionModel.RiverId && r.IsDeleted == false)
                    .Select(r => r.Name).FirstOrDefault();

                constructionModel.BasinName = _context.Basins?
                    .Where(b => b.Id == constructionModel.BasinId && b.IsDeleted == false)
                    .Select(b => b.Name).FirstOrDefault();

                constructionModel.SubBasinName = _context.SubBasins?
                    .Where(sb => sb.Id == constructionModel.SubBasinId && sb.IsDeleted == false)
                    .Select(sb => sb.Name).FirstOrDefault();

                listItems.Add(constructionModel);
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

            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

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
                var updateItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

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
            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Constructions!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
