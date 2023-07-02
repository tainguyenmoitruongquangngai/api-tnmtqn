using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
using new_wr_api.Models;
using System.Data;

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
                .Where(u => u.IsDeleted == false)
                .ToListAsync();

            var userDtos = new List<UsersDto>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var userDto = new UsersDto(user)
                {
                    Roles = roles?.Select(r => new RoleDto { Name = r }).ToList() ?? new List<RoleDto>()
                };
                userDtos.Add(userDto);
            }

            return userDtos;
        }



        public async Task<UsersDto?> GetUserByIdAsync(string userId)
        {
            if (userId == null)
            {
                return null;
            }

            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                return null;
            }

            var roles = await _userManager.GetRolesAsync(user);

            var userDto = new UsersDto(user)
            {
                Roles = roles?.Select(r => new RoleDto { Name = r }).ToList() ?? new List<RoleDto>()
            };

            return userDto;
        }

        public async Task<IdentityResult> CreateUserAsync(UsersDto dto)
        {
            var user = await _userManager.FindByNameAsync(dto.UserName);
            if (user != null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Username already exists" });
            }

            var newUser = new ApplicationUser
            {
                UserName = dto.UserName,
                Email = dto.Email,
                FullName = dto.FullName,
                PhoneNumber = dto.PhoneNumber,
                IsDeleted = false,
                Status = true,
            };

            var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);

            var res = await _userManager.CreateAsync(newUser, dto.PasswordHash);
            if (res.Succeeded)
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

                return res;
            }

            return res;
        }

        public async Task<IdentityResult?> UpdateUserAsync(string userName, UsersDto dto)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == userName, CancellationToken.None);

            // Update user properties based on the RegisterViewModel
            if (user == null)
            {
                return null;
            }

            user.FullName = dto.FullName;
            user.Email = dto.Email;
            user.PhoneNumber = dto.PhoneNumber;
            var res = await _userManager.UpdateAsync(user);
            return res;
        }


        public async Task<bool> DeleteUserAsync(string userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId, CancellationToken.None);

            // Update user properties based on the RegisterViewModel
            if (user == null)
            {
                return false;
            }

            user.IsDeleted = true;
            var res = await _userManager.UpdateAsync(user);
            return true;
        }
    }
}
