using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories
{
    public class RoleRepositories
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly DatabaseContext _context;

        public RoleRepositories(IServiceProvider serviceProvider, DatabaseContext context)
        {
            _roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            _context = context;
        }

        public async Task<List<ApplicationRole>> GetAllRolesAsync()
        {
            return await _context.Roles.Where(u => !u.IsDelete).ToListAsync();
        }

        public async Task<ApplicationRole?> GetRoleByIdAsync(string roleId)
        {
            if (roleId == null)
            {
                return null;
            }
            var res = await _roleManager.Roles.FirstOrDefaultAsync(u => u.Id == roleId, CancellationToken.None);
            return res;
        }

        public async Task<IdentityResult> CreateRoleAsync(string Name, bool isDefault)
        {
            var role = new ApplicationRole
            {
                Name = Name,
                IsDefault = isDefault,
                IsDelete = false,
            };
            var res = await _roleManager.CreateAsync(role);
            return res;
        }

        public async Task<IdentityResult?> UpdateRoleAsync(string roleId, RoleViewModel model)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.Id == roleId, CancellationToken.None);

            // Update role properties based on the RegisterViewModel
            if (role == null)
            {
                return null;
            }

            role.Name = model.Name;
            role.IsDefault = model.isDefault;
            var result = await _roleManager.UpdateAsync(role);
            return result;
        }

        public async Task<bool> DeleteRoleAsync(string roleId)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.Id == roleId, CancellationToken.None);

            // Update role properties based on the RegisterViewModel
            if (role == null)
            {
                return false;
            }
            role.IsDelete = true;
            var result = await _roleManager.UpdateAsync(role);
            return true;
        }
    }
}
