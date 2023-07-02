using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using new_wr_api.Data;
using new_wr_api.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Newtonsoft.Json;
using new_wr_api.Data.Dto;

namespace new_wr_api.Service
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public SignInManager<ApplicationUser> _signInManager { get; }

        private readonly IConfiguration _configuration;

        public AuthService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterAsync(UsersDto dto)
        {
            if (string.IsNullOrEmpty(dto.Id))
            {
                // Create a new user
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

                if (dto.PasswordHash == null) { return IdentityResult.Failed(); }

                var result = await _userManager.CreateAsync(newUser, dto.PasswordHash);

                if (result.Succeeded)
                {
                    // Add default role to the user
                    if (role != null && role.Name != null && role.IsDefault)
                    {
                        await _userManager.AddToRoleAsync(newUser, role.Name);
                    }
                }

                return result;
            }
            return IdentityResult.Failed();
        }

        public async Task<string> LoginAsync(LoginViewModel model)
        {
            var res = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
            if (!res.Succeeded)
            {
                return string.Empty;
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var roles = await _userManager.GetRolesAsync(user);

                var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Name, user.UserName ?? ""),
        };

                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
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

                var response = new
                {
                    user = new
                    {
                        email = user.Email,
                        fullName = user.FullName,
                        phoneNumber = user.PhoneNumber,
                        userName = user.UserName,
                    },
                    token = jwt,
                    role = roles,
                };

                return JsonConvert.SerializeObject(response);
            }

            return string.Empty;
        }

        public async Task<IdentityResult?> UpdatePasswordAsync(UsersDto dto, string currentPassword, string newPassword)
        {
            if (dto.UserName == null) { return null; }

            var user = await _userManager.FindByNameAsync(dto.UserName);

            if (user == null) { return null; }

            var res = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            return res;
        }

        public async Task<bool> AssignRoleAsync(AssignRoleModel model)
        {
            var u = await _userManager.FindByIdAsync(model.userId);

            var r = await _roleManager.FindByNameAsync(model.roleName);

            if (u == null) { return false; }

            if (r == null) { return false; }

            await _userManager.AddToRoleAsync(u, model.roleName);

            // Role assigned successfully
            return true;
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
