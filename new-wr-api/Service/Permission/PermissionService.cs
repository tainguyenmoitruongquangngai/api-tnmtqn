using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
using new_wr_api.Service.Permission;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class PermissionService : IPermissionService
    {
        private readonly DatabaseContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public PermissionService(DatabaseContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        public async Task<List<PermissionDto>> GetAllPermissionAsync()
        {
            var items = await _context.Permission!.Where(x => !x.IsDeleted).ToListAsync();
            var ret = items.Select(s => new PermissionDto(s)).ToList();

            return ret;
        }

        public async Task<PermissionDto?> GetPermissionByIdAsync(int Id)
        {
            var res = await _context.Permission!.FirstOrDefaultAsync(r => r.Id == Id);

            if (res == null) { return null; }

            var dashboardDto = new PermissionDto(res);
            return dashboardDto;
        }


        public async Task<IdentityResult> SavePermissionAsync(PermissionDto dto)
        {
            var existingItem = await _context.Permission!.FirstOrDefaultAsync(d => d.Id == dto.Id);

            if (existingItem == null || dto.Id == 0)
            {
                var item = dto.ToPermission();
                item.IsDeleted = false;
                item.Status = true;
                item.CreatedTime = DateTime.Now;
                item.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "defaultUser";
                _context.Permission!.Add(item);
                await _context.SaveChangesAsync();
            }
            else
            {
                existingItem.UserName = dto.UserName;
                existingItem.UserId = dto.UserId;
                existingItem.RoleId = dto.RoleId;
                existingItem.RoleName = dto.RoleName;
                existingItem.DashboardId = dto.DashboardId;
                existingItem.PermitName = dto.PermitName;
                existingItem.PermitCode = dto.PermitCode;
                existingItem.ModifiedTime = DateTime.Now;
                existingItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "defaultUser";
                _context.Update(existingItem);
                await _context.SaveChangesAsync();
            }
            return IdentityResult.Success;
        }


        public async Task<IdentityResult> DeletePermissionAsync(PermissionDto dto)
        {
            var existingItem = await _context.Permission!.FirstOrDefaultAsync(d => d.Id == dto.Id);

            existingItem!.IsDeleted = true;
            await _context.SaveChangesAsync();

            return IdentityResult.Success;
        }
    }
}
