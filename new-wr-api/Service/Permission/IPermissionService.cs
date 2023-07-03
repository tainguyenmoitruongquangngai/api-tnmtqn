using Microsoft.AspNetCore.Identity;
using new_wr_api.Data.Dto;

namespace new_wr_api.Service.Permission
{
    public interface IPermissionService
    {
        public Task<List<PermissionDto>> GetAllPermissionAsync();
        public Task<PermissionDto?> GetPermissionByIdAsync(int Id);
        public Task<IdentityResult> SavePermissionAsync(PermissionDto dto);
        public Task<IdentityResult> DeletePermissionAsync(PermissionDto dto);
    }
}
