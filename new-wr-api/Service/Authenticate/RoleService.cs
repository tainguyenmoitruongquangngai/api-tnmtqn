using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.Dto;

namespace new_wr_api.Service
{
    public class RoleService
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly DatabaseContext _context;

        public RoleService(IServiceProvider serviceProvider, DatabaseContext context, IHttpContextAccessor httpContext)
        {
            _roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            _context = context;
        }

        public async Task<List<ApplicationRole>> GetAllRolesAsync()
        {
            return await _context.Roles.Where(u => !u.IsDeleted).ToListAsync();
        }

        public async Task<ApplicationRole?> GetRoleByIdAsync(string roleId)
        {
            if (roleId == null) { return null; }
            var res = await _roleManager.FindByIdAsync(roleId);
            return res;
        }

        public async Task<IdentityResult> SaveRoleAsync(RoleDto dto)
        {
            var existingRole = await _roleManager.FindByIdAsync(dto.Id);

            if (existingRole == null)
            {
                // Create a new user
                ApplicationRole item = new ApplicationRole();

                item = dto.ToRoleDto();
                item.IsDeleted = false;
                item.Status = true;

                var res = await _roleManager.CreateAsync(item);
                return res;
            }
            else
            {
                existingRole.Name = dto.Name;
                existingRole.IsDefault = dto.IsDefault;

                var res = await _roleManager.UpdateAsync(existingRole);
                return res;
            }
        }

        public async Task<bool> DeleteRoleAsync(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            // Update role properties based on the RegisterViewModel
            if (role == null) { return false; }
            role.IsDeleted = true;
            var res = await _roleManager.UpdateAsync(role);
            return true;
        }
    }
}
