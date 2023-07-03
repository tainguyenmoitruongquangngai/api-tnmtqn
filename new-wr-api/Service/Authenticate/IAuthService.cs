using Microsoft.AspNetCore.Identity;
using new_wr_api.Models;
using new_wr_api.Models.Authenticate;

namespace new_wr_api.Service
{
    public interface IAuthService
    {
        public Task<IdentityResult> RegisterAsync(UserModel model);
        public Task<string> LoginAsync(LoginViewModel model);
        public Task<bool> LogoutAsync(HttpContext context);
        public Task<bool> AssignRoleAsync(AssignRoleModel model);
        public Task<IdentityResult?> UpdatePasswordAsync(UserModel model, string currentPassword, string newPassword);
    }
}
