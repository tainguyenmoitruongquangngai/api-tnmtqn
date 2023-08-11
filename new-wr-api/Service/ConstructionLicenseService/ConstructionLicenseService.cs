using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class ConstructionLicenseService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public ConstructionLicenseService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<bool> SaveConstructionLicenseAsync(ConstructionLicenseModel model)
        {
            var existingItem = await _context.ConstructionLicense!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<ConstructionLicense>(model);
                _context.ConstructionLicense!.Add(newItem);
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteConstructionLicenseAsync(ConstructionLicenseModel model)
        {
            var existingItem = await _context.ConstructionLicense!.FirstOrDefaultAsync(d => d.ConstructionId == model.ConstructionId && d.LicenseId == model.LicenseId);

            if (existingItem == null) { return false; }
            _context.ConstructionLicense!.Remove(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
