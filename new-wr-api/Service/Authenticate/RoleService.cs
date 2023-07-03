using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Service
{
    public class RoleService
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly DatabaseContext _context;

        public RoleService(IServiceProvider serviceProvider, DatabaseContext context)
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
            var res = await _roleManager.FindByIdAsync(roleId);
            return res;
        }

        public async Task<IdentityResult> SaveRoleAsync(RoleModel model)
        {
            var exitsItem = await _roleManager.FindByIdAsync(model.Id);

            if (exitsItem == null)
            {
                // Create a new user
                ApplicationRole item = new ApplicationRole();
                item.Name = model.Name;
                item.IsDefault = model.IsDefault;
                item.IsDeleted = false;
                item.Status = true;

                await _roleManager.CreateAsync(item);
            }
            else
            {
                exitsItem.Name = model.Name;
                exitsItem.IsDefault = model.IsDefault;

                await _roleManager.UpdateAsync(exitsItem);
            }
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteRoleAsync(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            // Update role properties based on the RegisterViewModel
            role!.IsDeleted = true;
            var res = await _roleManager.UpdateAsync(role);

            return IdentityResult.Success;
        }
    }
}
