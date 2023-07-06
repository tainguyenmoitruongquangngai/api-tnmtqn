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
            var items = await _context.Permissions!.Where(x => x.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<PermissionModel>>(items);
        }

        public async Task<PermissionModel?> GetPermissionByIdAsync(int Id)
        {
            var item = await _context.Permissions!.FindAsync(Id);
            return _mapper.Map<PermissionModel>(item);
        }


        public async Task<string> SavePermissionAsync(PermissionModel model)
        {
            var existingItem = await _context.Permissions!.FirstOrDefaultAsync(d => d.Id == model.Id);
            var res = "";

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Permissions>(model);
                newItem.IsDeleted = false;
                newItem.Status = true;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
                _context.Permissions!.Add(newItem);
                res = "Thêm dữ liệu thành công";
            }
            else
            {
                var updateItem = await _context.Permissions!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
                _context.Permissions!.Update(updateItem);
                res = "Cập nhật dữ liệu thành công";
            }

            await _context.SaveChangesAsync();
            return res;
        }


        public async Task<string> DeletePermissionAsync(PermissionModel modle)
        {
            var existingItem = await _context.Permissions!.FirstOrDefaultAsync(d => d.Id == modle.Id);

            if (existingItem == null) { return "Xóa dữ liệu thất bại"; }
            existingItem.IsDeleted = true;
            _context.Permissions!.Update(existingItem);
            await _context.SaveChangesAsync();
            return "Xóa dữ liệu thành công";
        }
    }
}
