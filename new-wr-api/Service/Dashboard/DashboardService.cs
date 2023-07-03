using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
using new_wr_api.Service.Dashboard;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class DashboardService : IDashboardService
    {
        private readonly DatabaseContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public DashboardService(DatabaseContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        public async Task<List<DashboardDto>> GetAllDashboardAsync()
        {
            var items = await _context.Dashboard!.Where(x => !x.IsDeleted).ToListAsync();
            var ret = items.Select(s => new DashboardDto(s)).ToList();

            return ret;
        }

        public async Task<DashboardDto?> GetDashboardByIdAsync(int Id)
        {
            var res = await _context.Dashboard!.FirstOrDefaultAsync(r => r.Id == Id);

            if (res == null) { return null; }

            var dashboardDto = new DashboardDto(res);
            return dashboardDto;
        }


        public async Task<IdentityResult> SaveDashboardAsync(DashboardDto dto)
        {
            var existingItem = await _context.Dashboard!.FirstOrDefaultAsync(d => d.Id == dto.Id);

            if (existingItem == null || dto.Id == 0)
            {
                var item = dto.ToDashboard();
                item.IsDeleted = false;
                item.Status = true;
                item.CreatedTime = DateTime.Now;
                item.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "defaultUser";
                _context.Dashboard!.Add(item);
                await _context.SaveChangesAsync();
            }
            else
            {
                existingItem.Name = dto.Name;
                existingItem.Path = dto.Path;
                existingItem.Description = dto.Description;
                existingItem.ModifiedTime = DateTime.Now;
                existingItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "defaultUser";
                _context.Update(existingItem);
                await _context.SaveChangesAsync();
            }
            return IdentityResult.Success;
        }


        public async Task<IdentityResult> DeleteDashboardAsync(DashboardDto dto)
        {
            var existingItem = await _context.Dashboard!.FirstOrDefaultAsync(d => d.Id == dto.Id);

            existingItem!.IsDeleted = true;
            await _context.SaveChangesAsync();

            return IdentityResult.Success;
        }
    }
}
