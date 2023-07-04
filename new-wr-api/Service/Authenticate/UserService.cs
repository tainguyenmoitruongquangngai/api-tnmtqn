using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class UserService
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _context;
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly RoleManager<AspNetRoles> _roleManager;
        private readonly IHttpContextAccessor _httpContext;


        public UserService(DatabaseContext context, UserManager<AspNetUsers> userManager, RoleManager<AspNetRoles> roleManager, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _mapper = mapper;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _httpContext = httpContext;
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            var items = await _context.Users!
                .Where(u => u.IsDeleted == false)
                .ToListAsync();

            var users = new List<UserModel>();

            foreach (var u in items)
            {
                var roles = await _userManager.GetRolesAsync(u);
                var user = new UserModel
                {
                    Id = u.Id,
                    UserName = u.UserName!,
                    FullName = u.FullName,
                    Email = u.Email!,
                    PhoneNumber = u.PhoneNumber!,
                    Roles = roles?.Select(r => new RoleModel { Name = r }).ToList() ?? new List<RoleModel>()
                };
                users.Add(user);
            }

            return users;
        }

        public async Task<UserModel> GetUserByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var userModel = _mapper.Map<UserModel>(user);
            return userModel;
        }

        public async Task<IdentityResult> SaveUserAsync(UserModel model)
        {
            var exitsingItem = await _userManager.FindByIdAsync(model.Id);
            AspNetUsers user;
            if (string.IsNullOrEmpty(model.Id))
            {
                // Create a new user
                user = new AspNetUsers
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "",
                    CreatedTime = DateTime.Now,
                    IsDeleted = false,
                    Status = true
                };

                var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault);
                var createResult = await _userManager.CreateAsync(user, model.PasswordHash);

                if (createResult.Succeeded && role != null)
                {
                    await _userManager.AddToRoleAsync(user, role.Name!);
                }
            }
            else
            {
                // Update an existing user
                user = exitsingItem!;
                if (user != null)
                {
                    user.FullName = model.FullName;
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    await _userManager.UpdateAsync(user);
                }
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteUserAsync(UserModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user != null)
            {
                user.IsDeleted = true;
                await _userManager.UpdateAsync(user);
            }

            return IdentityResult.Success;
        }
    }
}
