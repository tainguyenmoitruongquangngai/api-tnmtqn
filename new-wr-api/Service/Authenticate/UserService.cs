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
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            var roles = await _userManager.GetRolesAsync(user!);

            var userDto = new UsersDto(user!)
            {
                Roles = roles?.Select(r => new RoleDto { Name = r }).ToList() ?? new List<RoleDto>()
            };

            return userDto;
        }

        public async Task<IdentityResult> SaveUserAsync(UsersDto dto)
        {
            var exitsItem = await _userManager.FindByIdAsync(dto.Id);

            if (exitsItem == null)
            {
                // Create a new user
                ApplicationUser item = new ApplicationUser();

                item = dto.ToUsersDto();
                item.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "defaultUser";
                item.CreatedTime = DateTime.Now;
                item.IsDeleted = false;
                item.Status = true;

                var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);
                var res = await _userManager.CreateAsync(item, dto.PasswordHash!);

                if (res.Succeeded)
                {
                    // Add default role to the user
                    if (role!.IsDefault)
                    {
                        await _userManager.AddToRoleAsync(item, role.Name!);
                    }
                }
            }
            else
            {
                exitsItem.FullName = dto.FullName;
                exitsItem.Email = dto.Email;
                exitsItem.PhoneNumber = dto.PhoneNumber;
                await _userManager.UpdateAsync(exitsItem);
            }
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteUserAsync(UsersDto dto)
        {
            var user = await _userManager.FindByIdAsync(dto.Id);
            user!.IsDeleted = true;
            await _userManager.UpdateAsync(user);

            return IdentityResult.Success;
        }
    }
}
