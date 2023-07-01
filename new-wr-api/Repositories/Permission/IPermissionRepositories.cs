using new_wr_api.Models;

namespace new_wr_api.Repositories.Permission
{
    public interface IPermissionRepositories
    {
        public Task<List<PermissionModel>> GetAllPermissionAsync();
        public Task<PermissionModel> GetPermissionAsync(int Id);
        public Task<bool> CreatePermissionAsync(PermissionModel model);
        public Task<bool> UpdatePermissionAsync(int Id, PermissionModel model);
        public Task<bool> DeletePermissionAsync(int Id);
    }
}
