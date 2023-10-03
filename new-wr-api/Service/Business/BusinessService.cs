using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class BusinessService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public BusinessService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<BusinessModel>> GetAllBusinessAsync()
        {
            var items = await _context.Business!.Where(x => x.IsDeleted == false).OrderBy(x => x.Name).ToListAsync();
            return _mapper.Map<List<BusinessModel>>(items);
        }

        public async Task<BusinessModel?> GetBusinessByIdAsync(int Id)
        {
            var item = await _context.Business!.FindAsync(Id);
            return _mapper.Map<BusinessModel>(item);
        }


        public async Task<bool> SaveBusinessAsync(BusinessModel model)
        {
            var existingItem = await _context.Business!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<Business>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Business!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.Business!.FirstOrDefaultAsync(d => d.Id == model.Id && d.IsDeleted == false);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? "";
                _context.Business!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBusinessAsync(int Id)
        {
            var existingItem = await _context.Business!.FirstOrDefaultAsync(d => d.Id == Id && d.IsDeleted == false);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.Business!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
