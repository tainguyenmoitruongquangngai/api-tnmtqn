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

        // Constructor to initialize the service with required dependencies
        public GP_TCQService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        // Method to save a GP_TCQ entity
        public async Task<bool> SaveAsync(GP_TCQDto model)
        {
            // Retrieve an existing item based on IdTCQ and IdGP
            var existingItem = await _context.GP_TCQ!.FirstOrDefaultAsync(d => d.IdTCQ == model.IdTCQ && d.IdGP == model.IdGP);

            if (existingItem == null)
            {
                // If the item doesn't exist, create a new item
                var newItem = _mapper.Map<GP_TCQ>(model);
                _context.GP_TCQ!.Add(newItem);

                // Save changes to the database
                await _context.SaveChangesAsync();
            }

            // Return true to indicate successful save
            return true;
        }

        // Method to delete a GP_TCQ entity
        public async Task<bool> DeleteAsync(GP_TCQDto model)
        {
            // Retrieve an existing item based on IdTCQ and IdGP
            var existingItem = await _context.GP_TCQ!.FirstOrDefaultAsync(d => d.IdTCQ == model.IdTCQ && d.IdGP == model.IdGP);

            if (existingItem == null) { return false; } // If the item doesn't exist, return false

            // Remove the existing item
            _context.GP_TCQ!.Remove(existingItem);

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Return true to indicate successful deletion
            return true;
        }
    }
}
