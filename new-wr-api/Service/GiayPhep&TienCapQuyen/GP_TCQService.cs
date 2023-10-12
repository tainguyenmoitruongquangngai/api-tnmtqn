using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class GP_TCQService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public GP_TCQService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<bool> SaveAsync(GP_TCQDto model)
        {
            var existingItem = await _context.GP_TCQ!.FirstOrDefaultAsync(d => d.IdTCQ == model.IdTCQ && d.IdGP == model.IdGP);

            if (existingItem == null)
            {
                var newItem = _mapper.Map<GP_TCQ>(model);
                _context.GP_TCQ!.Add(newItem);
                await _context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> DeleteAsync(GP_TCQDto model)
        {
            var existingItem = await _context.GP_TCQ!.FirstOrDefaultAsync(d => d.IdTCQ == model.IdTCQ && d.IdGP == model.IdGP);

            if (existingItem == null) { return false; }
            _context.GP_TCQ!.Remove(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
