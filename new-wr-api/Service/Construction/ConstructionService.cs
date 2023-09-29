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
        private readonly UserManager<AspNetUsers> _userManager;

        public ConstructionService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
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
                if (ConstructionTypeId == 1 || ConstructionTypeId == 2 || ConstructionTypeId == 3 || ConstructionTypeId == 24)
                {
                    query = query.Where(x => x.Construction.ConstructionParentTypeId! == ConstructionTypeId);
                }
                else
                {
                    query = query.Where(x => x.Construction.ConstructionTypeId == ConstructionTypeId);
                }
            }

            if (PageSize > 0)
            {
                if (PageIndex < 1) PageIndex = 1;
                query = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            }
            var queryResults = await query.ToListAsync();

            var listItems = new List<ConstructionModel>();

            // THIẾT LẬP DỮ LIỆU KHÁC NGOÀI CÔNG TRÌNH
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
            int id = 0;
            //Notification? notify = new Notification();
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);
            Constructions? item = null; // Declare item variable

            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null || model.Id == 0)
            {
                item = _mapper.Map<Constructions>(model);
                item.IsDeleted = false;
                item.CreatedTime = DateTime.Now;
                item.CreatedUser = currentUser != null ? currentUser.UserName : null;

                _context.Constructions!.Add(item);

                // Notification
                //notify.NotifyTitle = "Giấy phép: " + item.LicenseNumber;
                //notify.NotifyContent = "Tài khoản " + currentUser!.UserName + " đã thêm 1 bản ghi: " + item.LicenseNumber;
            }
            else
            {
                item = existingItem; // Assign existingItem to item

                _mapper.Map(model, item); // Map properties from model to item
                item.ModifiedTime = DateTime.Now;
                item.ModifiedUser = currentUser != null ? currentUser.UserName : null;
                _context.Constructions!.Update(item);

                // Notification
                //notify.NotifyTitle = "Giấy phép: " + item.LicenseNumber;
                //notify.NotifyContent = "Tài khoản " + currentUser!.UserName + " đã sửa 1 bản ghi: " + item.LicenseNumber;
            }

            //var cons = await _context.Constructions!.FirstOrDefaultAsync(c => c.Id == item.ConstructionId);
            //notify.Url = "/giay-phep/" + GetUrl((int)(cons?.ConstructionParentTypeId != 2 ? cons?.ConstructionParentTypeId! : cons.ConstructionTypeId!)) + "?licenseNumber=" + item.LicenseNumber;
            //notify.Time = DateTime.Now;
            //_context.Notification!.Add(notify);

            var res = await _context.SaveChangesAsync();

            // Simplified assignment of id
            id = (int)(res > 0 ? item.Id : 0);

            return id;
        }


        public async Task<bool> DeleteConstructionAsync(int Id)
        {
            var existingItem = await _context.Constructions!.FirstOrDefaultAsync(d => d.Id == Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Constructions!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
