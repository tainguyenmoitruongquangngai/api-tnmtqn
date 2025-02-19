﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using new_wr_api.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Newtonsoft.Json;
using new_wr_api.Models.Authenticate;
using new_wr_api.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace new_wr_api.Service
{
    public class AuthService : IAuthService
    {
        private readonly Data.DatabaseContext _context;
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly RoleManager<AspNetRoles> _roleManager;

        public SignInManager<AspNetUsers> _signInManager { get; }

        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContext;

        public AuthService(UserManager<AspNetUsers> userManager, SignInManager<AspNetUsers> signInManager, RoleManager<AspNetRoles> roleManager, IConfiguration configuration, Data.DatabaseContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _httpContext = httpContext;
        }

        public async Task<bool> RegisterAsync(UserModel model)
        {
            // Create a new user
            AspNetUsers user = new AspNetUsers
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber,
                IsDeleted = false
            };

            var res = await _userManager.CreateAsync(user, model.Password!);

            var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);

            if (res.Succeeded && role != null)
            {
                await _userManager.AddToRoleAsync(user, role.Name!);
                return true;
            }
            return false;
        }

        public async Task<string> LoginAsync(LoginViewModel model)
        {
            var res = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
            if (!res.Succeeded)
            {
                return string.Empty;
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            var roles = await _userManager.GetRolesAsync(user!);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user!.Id),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("id", user.Id),
                new Claim(ClaimTypes.Name, user.UserName ?? ""),
                new Claim(ClaimTypes.NameIdentifier, user.FullName ?? ""),
            };

            var addedPermissions = new HashSet<string>(); // Sử dụng HashSet để lưu trữ các quyền đã thêm vào danh sách

            foreach (var role in roles)
            {

                claims.Add(new Claim(ClaimTypes.Role, role));

                // Lấy danh sách quyền thuộc vai trò
                var rolePermissions = await _context.Permissions!.Where(p => p.RoleName == role).ToListAsync();

                // Thêm quyền vào danh sách claims
                foreach (var permission in rolePermissions)
                {
                    // Lấy thông tin dashSrc từ SQL
                    var dashSrc = await _context.Dashboards!.Where(d => d.Id == permission.DashboardId).Select(d => d.Path).FirstOrDefaultAsync();

                    // Tạo một quyền dưới dạng đối tượng JSON
                    var permissionObject = new
                    {
                        funcCode = permission.FunctionCode,
                        dashSrc = dashSrc!
                    };

                    var permissionJson = JsonConvert.SerializeObject(permissionObject);

                    // Kiểm tra xem quyền đã được thêm vào danh sách chưa
                    if (!addedPermissions.Contains(permissionJson))
                    {
                        // Thêm quyền vào danh sách claims
                        var permissionClaim = new Claim("Permission", permissionJson);
                        claims.Add(permissionClaim);

                        // Đánh dấu quyền đã được thêm vào danh sách
                        addedPermissions.Add(permissionJson);
                    }
                }
            }

            // Lấy danh sách quyền theo tên người dùng
            var userPermissions = await _context.Permissions!.Where(p => p.UserName == user.UserName).ToListAsync();

            // Thêm quyền vào danh sách claims
            foreach (var permission in userPermissions)
            {
                // Lấy thông tin dashSrc từ SQL
                var dashSrc = await _context.Dashboards!.Where(d => d.Id == permission.DashboardId).Select(d => d.Path).FirstOrDefaultAsync();

                // Tạo một quyền dưới dạng đối tượng JSON
                var permissionObject = new
                {
                    funcCode = permission.FunctionCode,
                    dashSrc = dashSrc!
                };

                var permissionJson = JsonConvert.SerializeObject(permissionObject);

                // Kiểm tra xem quyền đã được thêm vào danh sách chưa
                if (!addedPermissions.Contains(permissionJson))
                {
                    // Thêm quyền vào danh sách claims
                    var permissionClaim = new Claim("Permission", permissionJson);
                    claims.Add(permissionClaim);

                    // Đánh dấu quyền đã được thêm vào danh sách
                    addedPermissions.Add(permissionJson);
                }
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? ""));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return JsonConvert.SerializeObject(jwt);
        }


        public async Task<bool> UpdatePasswordAsync(ChangePasswordModel model)
        {
            var ret = false;
            if (model.currentPassword != model.newConfirmPassword) ret = false;
            var user = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);
            if (user == null) ret = false;
            if (model.currentPassword != null || model.newPassword != null)
            {
                var res = await _userManager.ChangePasswordAsync(user!, model.currentPassword!, model.newPassword!);
                ret = res.Succeeded;
            }
            return ret;
        }

        public async Task<bool> SetPasswordAsync(SetPasswordModel model)
        {
            var user = await _userManager.FindByNameAsync(model.user!.UserName!);

            if (user != null)
            {
                var removePasswordResult = await _userManager.RemovePasswordAsync(user);
                if (removePasswordResult.Succeeded)
                {
                    var addPasswordResult = await _userManager.AddPasswordAsync(user, model.newPassword!);
                    return addPasswordResult.Succeeded;
                }
            }

            return false;
        }


        public async Task<bool> AssignRoleAsync(AssignRoleModel model)
        {
            var user = await _userManager.FindByIdAsync(model.userId);
            if (user == null) { return false; }

            // Remove all existing roles of the user
            var existingRoles = await _userManager.GetRolesAsync(user);
            if (existingRoles == null) { return false; }

            await _userManager.RemoveFromRolesAsync(user!, existingRoles);

            // Add the new role to the user
            await _userManager.AddToRoleAsync(user!, model.roleName);

            return true;
        }

        public async Task<bool> RemoveRoleAsync(AssignRoleModel model)
        {
            var u = await _userManager.FindByIdAsync(model.userId);
            // Check if the user is already in the role
            var isInRole = await _userManager.IsInRoleAsync(u!, model.roleName);
            if (isInRole)
            {
                await _userManager.RemoveFromRoleAsync(u!, model.roleName);
                var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);
                await _userManager.AddToRoleAsync(u!, role!.Name!);

                return true;
            }
            return false;
        }


        public async Task<bool> LogoutAsync(HttpContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return true;
        }

    }
}
