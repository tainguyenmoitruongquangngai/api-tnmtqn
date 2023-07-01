using new_wr_api.Models;

namespace new_wr_api.Repositories.Dashboard
{
    public interface IDashboardRepositories
    {
        public Task<List<DashboardModel>> GetAllDashboardAsync();
        public Task<DashboardModel> GetDashboardAsync(int Id);
        public Task<bool> CreateDashboardAsync(DashboardModel model);
        public Task<bool> UpdateDashboardAsync(int Id, DashboardModel model);
        public Task<bool> DeleteDashboardAsync(int Id);
    }
}
