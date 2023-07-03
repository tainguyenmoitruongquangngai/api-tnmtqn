using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
            var items = await _context.Permission!.Where(x => !x.IsDeleted).ToListAsync();
            return _mapper.Map<List<PermissionModel>>(items);
        }

        public async Task<PermissionModel?> GetPermissionByIdAsync(int Id)
        {
            var item = await _context.Permission!.FindAsync(Id);
            return _mapper.Map<PermissionModel>(item);
        }


        public async Task<IdentityResult> SavePermissionAsync(PermissionModel model)
        {
            var existingItem = await _context.Permission!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Permission>(model);
                newItem.IsDeleted = false;
                newItem.Status = true;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Permission!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Permission!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Permission!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return IdentityResult.Success;
        }


        public async Task<IdentityResult> DeletePermissionAsync(PermissionModel modle)
        {
            var existingItem = await _context.Permission!.FirstOrDefaultAsync(d => d.Id == modle.Id);

            existingItem!.IsDeleted = true;
            await _context.SaveChangesAsync();

            return IdentityResult.Success;
        }
    }
}
