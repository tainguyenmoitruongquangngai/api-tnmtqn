using Microsoft.AspNetCore.Identity;
using new_wr_api.Models;
using new_wr_api.Models.Authenticate;

namespace new_wr_api.Service
{
    public interface IAuthService
    {
        public Task<bool> RegisterAsync(UserModel model);
        public Task<string> LoginAsync(LoginViewModel model);
        public Task<bool> LogoutAsync(HttpContext context);
        public Task<bool> AssignRoleAsync(AssignRoleModel model);
        public Task<bool> RemoveRoleAsync(AssignRoleModel model);
        public Task<bool> UpdatePasswordAsync(UserModel model, string currentPassword, string newPassword);
        public Task<bool> SetPasswordAsync(UserModel model, string newPassword);

    }
}
