using new_wr_api.Models;

namespace new_wr_api.Repositories.Licenses
{
    public interface ILicensesRepositories
    {
        public Task<List<LicensesModel>> GetAllLicensesAsync();
        public Task<LicensesModel> GetLicenseAsync(int Id);
        public Task<bool> CreateLicenseAsync(LicensesModel model);
        public Task<bool> UpdateLicenseAsync(int Id, LicensesModel model);
        public Task<bool> DeleteLicenseAsync(int Id);
    }
}
