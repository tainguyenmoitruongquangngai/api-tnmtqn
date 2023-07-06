using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class DashboardService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public DashboardService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<DashboardModel>> GetAllDashboardAsync()
        {
            var dashboards = await _context!.Dashboards!.ToListAsync();
            var dashboardModels = _mapper.Map<List<DashboardModel>>(dashboards);

            var allFunctions = await _context!.Functions!.ToListAsync();
            foreach (var dashboardModel in dashboardModels)
            {
                dashboardModel.Functions = _mapper.Map<List<FunctionModel>>(allFunctions);
            }

            return dashboardModels;
        }

        public async Task<DashboardModel?> GetDashboardByIdAsync(int Id)
        {
            var item = await _context!.Dashboards!.FindAsync(Id);
            var dash = _mapper.Map<DashboardModel>(item);
            var functions = await _context!.Functions!.Where(x => x.Id > 0).ToListAsync();
            dash.Functions = _mapper.Map<List<FunctionModel>>(functions);

            return dash;
        }


        public async Task<bool> SaveDashboardAsync(DashboardModel model)
        {
            var existingItem = await _context.Dashboards!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Dashboards>(model);
                newItem.IsDeleted = false;
                newItem.Status = true;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Dashboards!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Dashboards!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Dashboards!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteDashboardAsync(DashboardModel model)
        {
            var existingItem = await _context.Dashboards!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Dashboards!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
