using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
using System.Data;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class UserService
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IHttpContextAccessor _httpContext;


        public UserService(DatabaseContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _httpContext = httpContext;
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
            if (userId == null) { return null; }

            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null) { return null; }

            var roles = await _userManager.GetRolesAsync(user);

            var userDto = new UsersDto(user)
            {
                Roles = roles?.Select(r => new RoleDto { Name = r }).ToList() ?? new List<RoleDto>()
            };

            return userDto;
        }

        public async Task<IdentityResult> SaveUserAsync(UsersDto dto)
        {
            var existingUser = await _userManager.FindByIdAsync(dto.Id);

            if (existingUser == null)
            {
                // Create a new user
                ApplicationUser item = new ApplicationUser();

                item = dto.ToUsersDto();
                item.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
                item.CreatedTime = DateTime.Now;
                item.IsDeleted = false;
                item.Status = true;

                var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);

                if (dto.PasswordHash == null) { return IdentityResult.Failed(new IdentityError { Description = "Password is null" }); }

                var res = await _userManager.CreateAsync(item, dto.PasswordHash);

                if (res.Succeeded)
                {
                    // Add default role to the user
                    if (role != null && role.Name != null && role.IsDefault)
                    {
                        await _userManager.AddToRoleAsync(item, role.Name);
                    }
                }

                return res;
            }
            else
            {
                // Update an existing user
                if (existingUser == null)
                {
                    return IdentityResult.Failed(new IdentityError { Description = "User does not exist" });
                }

                existingUser.FullName = dto.FullName;
                existingUser.Email = dto.Email;
                existingUser.PhoneNumber = dto.PhoneNumber;

                var res = await _userManager.UpdateAsync(existingUser);
                return res;
            }
        }

        public async Task<bool> DeleteUserAsync(UsersDto dto)
        {
            var user = await _userManager.FindByIdAsync(dto.Id);

            if (user == null) { return false; }

            user.IsDeleted = true;
            var res = await _userManager.UpdateAsync(user);
            return res.Succeeded;
        }
    }
}
