using Microsoft.AspNetCore.Identity;
using new_wr_api.Data.Dto;
using new_wr_api.Models;

namespace new_wr_api.Repositories
{
    public interface IAuthRepositories
    {
        public Task<IdentityResult> RegisterAsync(UsersDto dto);
        public Task<string> LoginAsync(LoginViewModel model);
        public Task<bool> LogoutAsync(HttpContext context);
        public Task<string> AssignRoleAsync(SetRoleModel model);
        public Task<IdentityResult?> UpdatePasswordAsync(UsersDto dto, string currentPassword, string newPassword);
    }
}
