using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories.Dashboard
{
    public class DashboardRepositories : IDashboardRepositories
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public DashboardRepositories(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateDashboardAsync(DashboardModel model)
        {
            var newDashboard = _mapper.Map<Data.Dashboard>(model);
            var currentDate = DateTime.Now;
            newDashboard.IsDeleted = false;
            newDashboard.Status = true;
            newDashboard.CreatedTime = currentDate;
            _context.Dashboard!.Add(newDashboard);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteDashboardAsync(int Id)
        {
            var dashboard = await _context.Dashboard!.FindAsync(Id);
            if (Id == dashboard!.Id)
            {
                var currentDate = DateTime.Now;
                dashboard.IsDeleted = true;
                dashboard.ModifiedTime = currentDate;
                _context.Dashboard!.Update(dashboard);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<DashboardModel> GetDashboardAsync(int id)
        {
            var dashboard = await _context.Dashboard!.FindAsync(id);
            return _mapper.Map<DashboardModel>(dashboard);
        }

        public async Task<List<DashboardModel>> GetAllDashboardAsync()
        {
            var dashboard = await _context.Dashboard!.Where(e => e.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<DashboardModel>>(dashboard);
        }

        public async Task<bool> UpdateDashboardAsync(int id, DashboardModel model)
        {
            var dashboard = await _context.Dashboard!.FindAsync(id);
            if (dashboard == null) return false;

            var currentDate = DateTime.Now;
            dashboard.IsDeleted = false;
            dashboard.ModifiedTime = currentDate;

            _mapper.Map(model, dashboard);

            await _context.SaveChangesAsync();

            return true;
        }

    }
}
