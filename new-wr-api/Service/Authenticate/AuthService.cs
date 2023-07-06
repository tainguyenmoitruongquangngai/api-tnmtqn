using Microsoft.AspNetCore.Authentication;
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

namespace new_wr_api.Service
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly RoleManager<AspNetRoles> _roleManager;

        public SignInManager<AspNetUsers> _signInManager { get; }

        private readonly IConfiguration _configuration;

        public AuthService(UserManager<AspNetUsers> userManager, SignInManager<AspNetUsers> signInManager, RoleManager<AspNetRoles> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterAsync(UserModel model)
        {
            var existingItem = await _userManager.FindByIdAsync(model.Id);

            if (existingItem != null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User is exits!" });
            }
            // Create a new user
            AspNetUsers user = new AspNetUsers();

            user.UserName = model.UserName;
            user.Email = model.Email;
            user.FullName = model.FullName;
            user.PhoneNumber = model.PhoneNumber;
            user.IsDeleted = false;
            user.Status = true;

            var res = await _userManager.CreateAsync(user, model.Password);

            var role = await _roleManager.Roles.FirstOrDefaultAsync(u => u.IsDefault == true);

            if (res.Succeeded && role != null)
            {
                await _userManager.AddToRoleAsync(user, role.Name!);
            }
            return res;
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

            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Sub, user!.Id),
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

        public async Task<IdentityResult?> UpdatePasswordAsync(UserModel model, string currentPassword, string newPassword)
        {
            var user = await _userManager.FindByNameAsync(model.UserName!);
            var res = await _userManager.ChangePasswordAsync(user!, currentPassword, newPassword);
            return res;
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
