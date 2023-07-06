using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class PermissionService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public PermissionService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<PermissionModel>> GetAllPermissionAsync()
        {
            var items = await _context.Permissions!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<PermissionModel>>(items);
        }

        public async Task<PermissionModel?> GetPermissionByIdAsync(int Id)
        {
            var item = await _context.Permissions!.FindAsync(Id);
            return _mapper.Map<PermissionModel>(item);
        }

        public async Task<bool> SavePermissionAsync(PermissionModel model)
        {
            var existingItem = await _context.Permissions!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Permissions>(model);
                _context.Permissions!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Permissions!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                _context.Permissions!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePermissionAsync(PermissionModel modle)
        {
            var existingItem = await _context.Permissions!.FirstOrDefaultAsync(d => d.FunctionId == modle.FunctionId && d.DashboardId == modle.DashboardId);

            if (existingItem == null) { return false; }

            _context.Permissions!.Remove(existingItem);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
