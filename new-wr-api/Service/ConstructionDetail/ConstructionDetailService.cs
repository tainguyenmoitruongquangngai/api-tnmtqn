using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class ConstructionDetailService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public ConstructionDetailService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<bool> SaveConstructionDetailAsync(ConstructionDetailModel model)
        {

            var existingItem = await _context.ConstructionDetails!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<ConstructionDetails>(model);
                newItem.IsDeleted = false;
                newItem.CreatedTime = DateTime.Now;
                newItem.CreatedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.ConstructionDetails!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.ConstructionDetails!.FirstOrDefaultAsync(d => d.Id == model.Id);

                updateItem = _mapper.Map(model, updateItem);

                updateItem!.ModifiedTime = DateTime.Now;
                updateItem.ModifiedUser = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.ConstructionDetails!.Update(updateItem);
            }

            var res = await _context.SaveChangesAsync();

            return true;
        }


        public async Task<bool> DeleteConstructionDetailAsync(ConstructionDetailModel model)
        {
            var existingItem = await _context.ConstructionDetails!.FirstOrDefaultAsync(d => d.Id == model.Id);

            if (existingItem == null) { return false; }

            existingItem!.IsDeleted = true;
            _context.ConstructionDetails!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
