using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class LicenseFeeService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public LicenseFeeService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<LicenseFeeModel>> GetAllLicenseFeeAsync()
        {
            var items = await _context!.LicenseFees!
                .Where(u => u.IsDeleted == false)
                .ToListAsync();

            var listItems = _mapper.Map<List<LicenseFeeModel>>(items);

            foreach (var item in listItems)
            {
                //LicenseFee.SupplementLicenseFee
                var supplementLicenseFee = await _context!.LicenseFees!.FirstOrDefaultAsync(lf => lf.Id == item.ChildrenId);
                item.SupplementLicenseFee = _mapper.Map<LicenseFeeModel>(supplementLicenseFee);
            }
            return listItems;
        }

        public async Task<LicenseFeeModel?> GetLicenseFeeByIdAsync(int Id)
        {
            var item = await _context.LicenseFees!.FindAsync(Id);
            return _mapper.Map<LicenseFeeModel>(item);
        }


        public async Task<bool> SaveLicenseFeeAsync(LicenseFeeModel model)
        {
            var existingItem = await _context.LicenseFees!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<LicenseFees>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.LicenseFees!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.LicenseFees!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.LicenseFees!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteLicenseFeeAsync(LicenseFeeModel modle)
        {
            var existingItem = await _context.LicenseFees!.FirstOrDefaultAsync(d => d.Id == modle.Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.LicenseFees!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
