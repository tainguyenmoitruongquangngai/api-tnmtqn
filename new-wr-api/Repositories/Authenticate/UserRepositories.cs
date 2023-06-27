using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories
{
    public class UserRepositories
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserRepositories(DatabaseContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ApplicationUser?> GetUserByIdAsync(string userId)
        {
            if (userId == null)
            {
                return null;
            }
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId, CancellationToken.None);
            return user;
        }

        public async Task<IdentityResult> CreateUserAsync(RegisterViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Username already exists" });
            }

            var newUser = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber,
            };

            var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);

            var result = await _userManager.CreateAsync(newUser, model.Password);
            if (result.Succeeded)
            {

                // Add default role to the user
                if (role != null)
                {
                    if (role.Name != null)
                    {
                        if (role.IsDefault)
                        {
                            await _userManager.AddToRoleAsync(newUser, role.Name);
                        }
                    }
                }

                return result;
            }

            return result;
        }

        public async Task<IdentityResult?> UpdateUserAsync(string userId, UpdateUserViewModel model)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId, CancellationToken.None);

            // Update user properties based on the RegisterViewModel
            if (user == null)
            {
                return null;
            }

            user.FullName = model.FullName;
            user.Email = model.Email;
            user.UserType = model.UserType;
            var result = await _userManager.UpdateAsync(user);
            return result;
        }


        public async Task<bool> DeleteUserAsync(string userId)
        {
            if (userId == null)
            {
                return false;
            }
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId, CancellationToken.None);
            if (user == null)
            {
                return false;
            }
            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded;
        }

        public async Task<IdentityResult?> UpdatePasswordAsync(string userId, string currentPassword, string newPassword)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId, CancellationToken.None);
            if (user == null)
            {
                return null;
            }
            var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            return result;
        }

    }
}
