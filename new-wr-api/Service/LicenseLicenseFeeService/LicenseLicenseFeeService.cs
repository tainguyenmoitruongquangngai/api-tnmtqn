using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class LicenseLicenseFeeService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public LicenseLicenseFeeService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<bool> SaveLicenseLicenseFeeAsync(LicenseLicenseFeeModel model)
        {
            var existingItem = await _context.LicenseLicenseFee!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<LicenseLicenseFee>(model);
                _context.LicenseLicenseFee!.Add(newItem);
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteLicenseLicenseFeeAsync(LicenseLicenseFeeModel model)
        {
            var existingItem = await _context.LicenseLicenseFee!.FirstOrDefaultAsync(d => d.LicenseFeeId == model.LicenseFeeId && d.LicenseId == model.LicenseId);

            if (existingItem == null) { return false; }
            _context.LicenseLicenseFee!.Remove(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
