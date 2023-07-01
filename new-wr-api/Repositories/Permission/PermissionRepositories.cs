using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories.Permission
{
    public class PermissionRepositories : IPermissionRepositories
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public PermissionRepositories(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreatePermissionAsync(PermissionModel model)
        {
            var newPermission = _mapper.Map<Data.Permission>(model);

            var currentDate = DateTime.Now;

            newPermission.IsDeleted = false;

            newPermission.Status = false;

            newPermission.CreatedTime = currentDate;

            _context.Permission!.Add(newPermission);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePermissionAsync(int Id)
        {
            var permission = await _context.Permission!.FindAsync(Id);
            var currentDate = DateTime.Now;
            if (Id == permission!.Id)
            {

                permission.IsDeleted = true;

                permission.ModifiedTime = currentDate;

                _context.Permission!.Update(permission);

                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<PermissionModel> GetPermissionAsync(int id)
        {
            var permission = await _context.Permission!.FindAsync(id);

            return _mapper.Map<PermissionModel>(permission);
        }

        public async Task<List<PermissionModel>> GetAllPermissionAsync()
        {
            var permission = await _context.Permission!.Where(e => e.IsDeleted == false).ToListAsync();

            return _mapper.Map<List<PermissionModel>>(permission);
        }

        public async Task<bool> UpdatePermissionAsync(int id, PermissionModel model)
        {
            var permission = await _context.Permission!.FindAsync(id);

            var currentDate = DateTime.Now;

            if (permission == null) return false;

            permission.ModifiedTime = currentDate;

            _mapper.Map(model, permission);

            _context.Permission!.Update(permission);

            await _context.SaveChangesAsync();

            return true;
        }

    }
}
