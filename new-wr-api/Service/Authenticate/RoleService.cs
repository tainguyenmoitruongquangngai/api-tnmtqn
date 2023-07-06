using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Service
{
    public class RoleService
    {
        private readonly RoleManager<AspNetRoles> _roleManager;
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public RoleService(IServiceProvider serviceProvider, DatabaseContext context, IMapper mapper)
        {
            _roleManager = serviceProvider.GetRequiredService<RoleManager<AspNetRoles>>();
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<RoleModel>> GetAllRolesAsync()
        {
            var items = await _context.Roles.ToListAsync();
            var listItems = _mapper.Map<List<RoleModel>>(items);

            foreach (var item in listItems)
            {
                var dashIds = _context!.RoleDashboards!.Where(x => x.RoleId == item.Id).Select(x => x.DashboardId).ToList();
                var dashboards = await _context!.Dashboards!.Where(x => dashIds.Contains(x.Id)).ToListAsync();
                item.Dashboards = _mapper.Map<List<DashboardModel>>(dashboards);
                foreach (var dash in item.Dashboards)
                {
                    var functions = await _context!.Functions!.Where(x => x.Id > 0).ToListAsync();
                    dash.Functions = _mapper.Map<List<FunctionModel>>(functions);
                }
            }

            return listItems;
        }

        public async Task<RoleModel> GetRoleByIdAsync(string roleId)
        {
            var item = await _roleManager.FindByIdAsync(roleId);
            var role = _mapper.Map<RoleModel>(item);
            var dashIds = _context!.RoleDashboards!.Where(x => x.RoleId == roleId).Select(x => x.DashboardId).ToList();
            var dashboards = await _context!.Dashboards!.Where(x => dashIds.Contains(x.Id)).ToListAsync();
            role.Dashboards = _mapper.Map<List<DashboardModel>>(dashboards);
            foreach (var dash in role.Dashboards)
            {
                var functions = await _context!.Functions!.Where(x => x.Id > 0).ToListAsync();
                dash.Functions = _mapper.Map<List<FunctionModel>>(functions);
            }

            return role;
        }


        public async Task<IdentityResult> SaveRoleAsync(RoleModel model)
        {
            var exitsItem = await _roleManager.FindByIdAsync(model.Id);

            if (exitsItem == null)
            {
                // Create a new user
                AspNetRoles item = new AspNetRoles();
                item.Name = model.Name;
                item.IsDefault = model.IsDefault;
                item.IsDeleted = false;
                item.Status = true;

                await _roleManager.CreateAsync(item);
            }
            else
            {
                exitsItem.Name = model.Name;
                exitsItem.IsDefault = model.IsDefault;

                await _roleManager.UpdateAsync(exitsItem);
            }
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteRoleAsync(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            // Update role properties based on the RegisterViewModel
            role!.IsDeleted = true;
            var res = await _roleManager.UpdateAsync(role);

            return IdentityResult.Success;
        }
    }
}
