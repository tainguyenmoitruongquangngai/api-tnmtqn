using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
using new_wr_api.Service.Dashboard;
using System.Linq;

namespace new_wr_api.Service
{
    public class DashboardService : IDashboardService
    {
        private readonly DatabaseContext _context;

        public DashboardService(DatabaseContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
        }

        public async Task<List<DashboardDto>> GetAllDashboardAsync()
        {
            var dashboard = _context.Dashboard;

            if (dashboard == null)
            {
                return new List<DashboardDto>();
            }

            var items = await dashboard.Where(x => !x.IsDeleted).ToListAsync();
            var ret = items.Select(s => new DashboardDto(s)).ToList();

            return ret;
        }

        public async Task<DashboardDto?> GetDashboardByIdAsync(int Id)
        {
            var dashboard = _context.Dashboard;

            if (dashboard == null)
            {
                return null;
            }

            var res = await dashboard.FirstOrDefaultAsync(r => r.Id == Id);

            if (res == null)
            {
                return null;
            }

            var dashboardDto = new DashboardDto(res);
            return dashboardDto;
        }


        public Task<IdentityResult> SaveDashboardAsync(DashboardDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDashboardAsync(DashboardDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
