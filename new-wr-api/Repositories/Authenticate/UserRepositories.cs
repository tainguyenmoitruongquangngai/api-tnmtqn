using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
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
        public async Task<List<UsersDto>> GetAllUsersAsync()
        {
            var users = await _context.Users
                .Where(u => !u.IsDelete)
                .ToListAsync();

            var userDtos = new List<UsersDto>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var userDto = new UsersDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FullName = user.FullName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    UserType = user.UserType,
                    Roles = roles.ToList()
                };
                userDtos.Add(userDto);
            }

            return userDtos;
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
                IsDelete = false,
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

        public async Task<IdentityResult?> UpdateUserAsync(string userName, UpdateUserViewModel model)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == userName, CancellationToken.None);

            // Update user properties based on the RegisterViewModel
            if (user == null)
            {
                return null;
            }

            user.FullName = model.FullName;
            user.Email = model.Email;
            user.UserType = model.UserType;
            user.PhoneNumber = model.PhoneNumber;
            var result = await _userManager.UpdateAsync(user);
            return result;
        }


        public async Task<bool> DeleteUserAsync(string userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId, CancellationToken.None);

            // Update user properties based on the RegisterViewModel
            if (user == null)
            {
                return false;
            }

            user.IsDelete = true;
            var result = await _userManager.UpdateAsync(user);
            return true;
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

        public async Task<string> AssignRoleAsync(SetRoleModel model)
        {
            var user = await _userManager.FindByIdAsync(model.userId);
            if (user == null)
            {
                // User not found
                return "User not found";
            }

            var roleExists = await _roleManager.RoleExistsAsync(model.roleName);
            if (!roleExists)
            {
                // Role not found
                return "Role not found";
            }

            await _userManager.AddToRoleAsync(user, model.roleName);

            // Role assigned successfully
            return "Role assigned successfully";
        }

    }
}
