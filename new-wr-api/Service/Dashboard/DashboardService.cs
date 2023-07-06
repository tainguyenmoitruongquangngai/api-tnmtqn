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

        public async Task<List<RoleDashboardModel>> GetDashboardByRoleAsync(string roleName)
        {
            var role = await _context!.Roles!.FirstOrDefaultAsync(x => x!.Name!.ToLower().Contains(roleName));
            var dashboards = await _context!.Dashboards!.Where(x => x.IsDeleted == false).ToListAsync();
            var roleDashboards = new List<RoleDashboardModel>();

            foreach (var dashboard in dashboards)
            {
                var rdash = await _context!.RoleDashboards!
                    .FirstOrDefaultAsync(x => x.RoleName == roleName && x.DashboardId == dashboard.Id);

                var model = new RoleDashboardModel
                {
                    DashboardId = dashboard.Id,
                    DashboardName = dashboard.Name,
                    FileControl = dashboard.Path,
                    RoleId = role?.Id
                };

                if (rdash != null)
                {
                    model.Id = rdash.Id;
                    model.RoleId = rdash.RoleId;
                    model.RoleName = rdash.RoleName;
                    model.PermitAccess = (bool)rdash.PermitAccess!;
                }
                else
                {
                    model.RoleId = role?.Id;
                    model.RoleName = role?.Name;
                    model.PermitAccess = false;
                }

                roleDashboards.Add(model);
            }

            return _mapper.Map<List<RoleDashboardModel>>(roleDashboards);
        }


        public async Task<List<DashboardModel>> GetDashboardByUserAsync(UserModel user)
        {
            var dashId = _context!.UserDashboards!.Where(x => x.UserId == user.Id).Select(x => x.DashboardId).ToList();
            var dashboards = await _context!.Dashboards!.Where(x => dashId.Contains(x.Id)).ToListAsync();
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
