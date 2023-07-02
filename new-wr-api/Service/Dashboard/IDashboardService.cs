using Microsoft.AspNetCore.Identity;
using new_wr_api.Data.Dto;

namespace new_wr_api.Service.Dashboard
{
    public interface IDashboardService
    {
        public Task<List<DashboardDto>> GetAllDashboardAsync();
        public Task<DashboardDto?> GetDashboardByIdAsync(int Id);
        public Task<IdentityResult> SaveDashboardAsync(DashboardDto dto);
        public Task<bool> DeleteDashboardAsync(DashboardDto dto);
    }
}
