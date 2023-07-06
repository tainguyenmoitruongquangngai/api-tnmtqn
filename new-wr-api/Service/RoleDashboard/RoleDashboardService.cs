using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service.RoleDashboard
{
    public class RoleDashboardService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public RoleDashboardService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<RoleDashboardModel>> GetAllRoleDashboardAsync()
        {
            var items = await _context.RoleDashboards!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<RoleDashboardModel>>(items);
        }

        public async Task<RoleDashboardModel> GetRoleDashboardByIdAsync(int Id)
        {
            var item = await _context!.RoleDashboards!.FindAsync(Id);
            return _mapper.Map<RoleDashboardModel>(item);
        }

        public async Task<IdentityResult> SaveRoleDashboardAsync(RoleDashboardModel model)
        {
            var exitsItem = await _context!.RoleDashboards!.FindAsync(model.Id);

            if (exitsItem == null || model.Id == 0) {
                var newItem = _mapper.Map<RoleDashboards>(model);

                _context.RoleDashboards!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.RoleDashboards!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);
                _context.RoleDashboards!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return IdentityResult.Success;
        }


        public async Task<IdentityResult> DeleteRoleDashboardAsync(RoleDashboardModel model)
        {
            var exitsItem = await _context!.RoleDashboards!.FindAsync(model.Id);
            _context.RoleDashboards.Remove(exitsItem!);

            return IdentityResult.Success;
        }
    }
}
