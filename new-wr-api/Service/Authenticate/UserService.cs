using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Models.Authenticate;
using System.Data;
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
            var items = await _context.Users
                .Where(u => u.IsDeleted == false)
                .ToListAsync();

            var users = new List<UserModel>();

            foreach (var u in items)
            {
                var user = new UserModel
                {
                    Id = u.Id,
                    UserName = u.UserName!,
                    FullName = u.FullName!,
                    Email = u.Email!,
                    PhoneNumber = u.PhoneNumber!
                };

                var roles = await _userManager.GetRolesAsync(u);
                if (roles.Count > 0)
                {
                    var role = await _roleManager.FindByNameAsync(roles[0]);
                    if (role != null)
                    {
                        user.Role = role.Name;
                    }
                }

                users.Add(user);
            }

            return users;
        }

        public async Task<UserInfoModel> GetUserInfoByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var userInfo = _mapper.Map<UserInfoModel>(user);

            var roles = await _userManager.GetRolesAsync(user!);
            var roleName = roles.FirstOrDefault();
            userInfo.Role = roleName;

            var dashIds = _context!.UserDashboards!.Where(x => x.UserId == userInfo.Id).Select(x => x.DashboardId).ToList();
            var dashboards = await _context!.Dashboards!.Where(x => dashIds.Contains(x.Id)).ToListAsync();
            userInfo.Dashboards = _mapper.Map<List<DashboardModel>>(dashboards);
            foreach (var dash in userInfo.Dashboards)
            {
                var functions = await _context!.Functions!.Where(x => x.Id > 0).ToListAsync();
                dash.Functions = _mapper.Map<List<FunctionModel>>(functions);
                foreach (var function in dash.Functions)
                {
                    var existingPermission = await _context!.Permissions!
                        .FirstOrDefaultAsync(d => d.FunctionId == function.Id && d.DashboardId == dash.Id && d.UserId == userInfo.Id);

                    if (existingPermission != null)
                    {
                        function.Status = true;
                    }
                    else
                    {
                        function.Status = false;
                    }
                }
            }

            return userInfo;

        }

        public async Task<UserModel> GetUserByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var userModel = _mapper.Map<UserModel>(user);
            return userModel;
        }

        public async Task<bool> SaveUserAsync(UserModel model)
        {
            var existingItem = await _userManager.FindByIdAsync(model.Id);

            if (existingItem == null)
            {
                // Create a new user
                AspNetUsers user = new AspNetUsers();

                user.UserName = model.UserName;
                user.Email = model.Email;
                user.FullName = model.FullName;
                user.PhoneNumber = model.PhoneNumber;
                user.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                user.CreatedTime = DateTime.Now;
                user.IsDeleted = false;

                var res = await _userManager.CreateAsync(user, model.Password);

                var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);

                if (res.Succeeded && role != null)
                {
                    await _userManager.AddToRoleAsync(user, role.Name!);
                    return true;
                }
                return false;
            }
            else
            {
                // Update an existing user
                existingItem.UserName = model.UserName;
                existingItem.Email = model.Email;
                existingItem.FullName = model.FullName;
                existingItem.PhoneNumber = model.PhoneNumber;
                existingItem.ModifiedTime = DateTime.Now;
                existingItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                var res = await _userManager.UpdateAsync(existingItem);
                if (res.Succeeded)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> DeleteUserAsync(UserModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id!);
            if (user != null)
            {
                user.IsDeleted = true;
                await _userManager.UpdateAsync(user);
                return true;
            }
            return false;

        }
    }
}
