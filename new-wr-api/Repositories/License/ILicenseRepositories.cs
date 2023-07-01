using new_wr_api.Models;

namespace new_wr_api.Repositories.License
{
    public interface ILicenseRepositories
    {
        public Task<List<LicenseModel>> GetAllLicenseAsync();
        public Task<LicenseModel> GetLicenseAsync(int Id);
        public Task<bool> CreateLicenseAsync(LicenseModel model);
        public Task<bool> UpdateLicenseAsync(int Id, LicenseModel model);
        public Task<bool> DeleteLicenseAsync(int Id);
    }
}
