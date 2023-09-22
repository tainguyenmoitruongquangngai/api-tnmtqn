using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Collections.Generic;
using System.ComponentModel;
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

        public async Task<List<LicenseModel>> GetAllLicenseAsync(string? LicenseNumber, string? LicensingAuthorities, int? LicenseTypeId, string? LicenseValidity, int? BusinessId, int? ConstructionId, int? ConstructionTypeId, int? DistrictId, int? CommuneId, int? SubBasinId, int PageIndex, int PageSize)
        {
            //TRUY VẤN DỮ LIỆU
            var query = from license in _context.Licenses
                        where license.IsDeleted == false
                            && (string.IsNullOrEmpty(LicenseNumber) || license.LicenseNumber!.ToLower().Contains(LicenseNumber.ToLower()))
                            && (string.IsNullOrEmpty(LicensingAuthorities) || license.LicensingAuthorities!.ToLower().Contains(LicensingAuthorities.ToLower()))
                            && (LicenseTypeId == 0 || license.LicensingTypeId == LicenseTypeId)
                            && (BusinessId == 0 || license.BusinessId == BusinessId)
                            && (ConstructionId == 0 || license.ConstructionId == ConstructionId)
                        orderby license.SignDate descending
                        select new
                        {
                            License = license,
                            Construction = _context.Constructions!
                                .FirstOrDefault(c => c.Id == license.ConstructionId && c.IsDeleted == false)
                        };

            query = query
                .Where(x =>
                    (ConstructionTypeId == 0 || x.Construction.ConstructionTypeId == ConstructionTypeId) &&
                    (DistrictId == 0 || x.Construction.DistrictId.ToString() == DistrictId.ToString()) &&
                    (CommuneId == 0 || x.Construction.CommuneId.ToString() == CommuneId.ToString()) &&
                    (SubBasinId == 0 || x.Construction.SubBasinId == SubBasinId));

            if (!string.IsNullOrEmpty(LicenseValidity))
            {
                switch (LicenseValidity.ToLower())
                {
                    case "sap-het-hieu-luc":
                        query = query
                            .Where(x => x.License.ExpriteDate.HasValue &&
                                        x.License.ExpriteDate >= DateTime.Today &&
                                        x.License.ExpriteDate < DateTime.Today.AddDays(160) &&
                                        x.License.IsRevoked == false);
                        break;
                    case "het-hieu-luc":
                        query = query
                            .Where(x => x.License.ExpriteDate.HasValue &&
                                        x.License.ExpriteDate < DateTime.Today &&
                                        x.License.IsRevoked == false);
                        break;
                    case "con-hieu-luc":
                        query = query
                            .Where(x => x.License.ExpriteDate.HasValue &&
                                        x.License.ExpriteDate > DateTime.Today.AddDays(160) &&
                                        x.License.IsRevoked == false);
                        break;
                    case "da-bi-thu-hoi":
                        query = query.Where(x => x.License.IsRevoked == true);
                        break;
                    default: break;
                }
            }



            if (PageSize > 0)
            {
                if (PageIndex < 1) PageIndex = 1;
                query = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            }

            var queryResults = await query.ToListAsync();

            var listItems = new List<LicenseModel>();

            // THIẾT LẬP DỮ LIỆU KHÁC NGOÀI GIẤY PHÉP
            foreach (var queryResult in queryResults)
            {
                var constructionId = queryResult.Construction?.Id;

                var licenseModel = new LicenseModel
                {
                    Construction = new ConstructionModel(),
                    Business = new BusinessModel()
                };

                // Ánh xạ dữ liệu License
                _mapper.Map(queryResult.License, licenseModel);

                //Ánh xạ dữ liệu OldLicense
                var oldLicense = await _context!.Licenses!.FirstOrDefaultAsync(ol => ol.Id == licenseModel.ChildId && ol.IsDeleted == false);
                licenseModel.OldLicense = _mapper.Map<LicenseModel>(oldLicense);

                // Ánh xạ dữ liệu Business
                _mapper.Map(await _context.Business!.FirstOrDefaultAsync(b => b.Id == queryResult.License.BusinessId && b.IsDeleted == false), licenseModel.Business);

                // Lấy danh sách LicenseFees và ánh xạ vào LicenseModel
                var licFeeIds = await _context.LicenseLicenseFee!
                    .Where(x => x.LicenseId == licenseModel.Id)
                    .Select(x => x.LicenseFeeId)
                    .ToListAsync();

                var licFees = await _context.LicenseFees!
                    .Where(x => licFeeIds.Contains(x.Id) && !x.IsDeleted)
                    .ToListAsync();

                licenseModel.LicenseFees = _mapper.Map<List<LicenseFeeModel>>(licFees);

                // Ánh xạ dữ liệu Construction
                _mapper.Map(queryResult.Construction, licenseModel.Construction);

                // Ánh xạ dữ liệu ConstructionItems
                licenseModel.Construction!.ConstructionItems = _mapper.Map<List<ConstructionItemModel>>(await _context.ConstructionItems!
                    .Where(x => x.ConstructionId == constructionId && x.IsDeleted == false)
                    .ToListAsync());

                //Loại công trình
                var consType = await _context.ConstructionTypes!.FirstOrDefaultAsync(x => x.Id == licenseModel.Construction.ConstructionTypeId);
                licenseModel.Construction.ConstructionTypeName = consType?.TypeName;

                //Lấy Huyện, Xã, Sông, Lưu vực sông, Tiểu vùng quy hoạch
                var location = await _context.Locations!
                    .FirstOrDefaultAsync(
                           l => l.DistrictId == licenseModel.Construction.DistrictId.ToString()
                        && l.CommuneId == licenseModel.Construction.CommuneId.ToString()
                        && l.IsDeleted == false);

                //Huyện
                licenseModel.Construction.DistrictName = location?.DistrictName;

                //Xã
                licenseModel.Construction.CommuneName = location?.CommuneName;

                //Sông
                licenseModel.Construction.RiverName = await _context.Rivers!
                    .Where(r => r.Id == licenseModel.Construction.RiverId && r.IsDeleted == false)
                    .Select(r => r.Name)
                    .FirstOrDefaultAsync();

                //Lưu vực sông
                licenseModel.Construction.BasinName = await _context.Basins!
                    .Where(b => b.Id == licenseModel.Construction.BasinId && b.IsDeleted == false)
                    .Select(b => b.Name)
                    .FirstOrDefaultAsync();

                //Tiểu vùng quy hoạch
                licenseModel.Construction.SubBasinName = await _context.SubBasins!
                    .Where(sb => sb.Id == licenseModel.Construction.SubBasinId && sb.IsDeleted == false)
                    .Select(sb => sb.Name)
                    .FirstOrDefaultAsync();

                //Hiệu lực giấy phép
                if (licenseModel.IsRevoked == true)
                {
                    licenseModel.LicenseValidity = "da-bi-thu-hoi";
                }
                else if (licenseModel.ExpriteDate.HasValue)
                {
                    DateTime expireDate = licenseModel.ExpriteDate.Value;
                    if (expireDate >= DateTime.Today && expireDate < DateTime.Today.AddDays(160))
                    {
                        licenseModel.LicenseValidity = "sap-het-hieu-luc";
                    }
                    else if (expireDate < DateTime.Today)
                    {
                        licenseModel.LicenseValidity = "het-hieu-luc";
                    }
                    else if (expireDate > DateTime.Today.AddDays(160))
                    {
                        licenseModel.LicenseValidity = "con-hieu-luc";
                    }
                }
                else
                {
                    licenseModel.LicenseValidity = "con-hieu-luc";
                }

                var licTypes = await _context.LicenseTypes!.FirstOrDefaultAsync(l => l.Id == licenseModel.LicensingTypeId && l.IsDeleted == false);
                licenseModel.LicenseTypeName = licTypes?.TypeName;

                listItems.Add(licenseModel);
            }

            return listItems;
        }

        public async Task<List<LicenseModel>?> GetLicenseForCountAsync()
        {
            var item = await _context.Licenses!.Where(x => x.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<LicenseModel>>(item);
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

            var existingItem = await _context.Licenses!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

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
            var existingItem = await _context.Licenses!.FirstOrDefaultAsync(d => d.Id == modle.Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Licenses!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
