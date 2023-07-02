using new_wr_api.Models;

namespace new_wr_api.Service.Dashboard
{
    public interface IDashboardService
    {
        public Task<List<DashboardModel>> GetAllDashboardAsync();
        public Task<DashboardModel> GetDashboardAsync(int Id);
        public Task<bool> CreateDashboardAsync(DashboardModel model);
        public Task<bool> UpdateDashboardAsync(int Id, DashboardModel model);
        public Task<bool> DeleteDashboardAsync(int Id);
    }
}
