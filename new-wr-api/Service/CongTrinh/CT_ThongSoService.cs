using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class CT_ThongSoService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AspNetUsers> _userManager;

        // Constructor to initialize the service with required dependencies
        public CT_ThongSoService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
        }

        // Method to save or update a CT_ThongSo entity
        public async Task<bool> SaveAsync(CT_ThongSoDto dto)
        {
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);

            var existingItem = await _context.CT_ThongSo!
                    .FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                // Create a new item if it doesn't exist or dto.Id is 0
                var newItem = _mapper.Map<CT_ThongSo>(dto);

                // Set nullable properties to null if their values are 0
                if (dto.IdHangMucCT == 0)
                {
                    newItem.IdHangMucCT = null;
                }
                if (dto.IdCT == 0)
                {
                    newItem.IdCT = null;
                }

                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongSo!.Add(newItem);
            }
            else
            {
                // Update the existing item with values from the dto
                var updateItem = _mapper.Map(dto, existingItem);

                // Set nullable properties to null if their values are 0
                if (dto.IdHangMucCT == 0)
                {
                    updateItem.IdHangMucCT = null;
                }
                if (dto.IdCT == 0)
                {
                    updateItem.IdCT = null;
                }

                updateItem.DaXoa = false;
                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongSo!.Update(updateItem);
            }

            // Save changes to the database
            await _context.SaveChangesAsync();
            return true;
        }

        // Method to delete a CT_ThongSo entity
        public async Task<bool> DeleteAsync(int Id)
        {
            // Retrieve an existing item based on Id
            var existingItem = await _context.CT_ThongSo!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);

            if (existingItem == null) { return false; } // If the item doesn't exist, return false

            existingItem!.DaXoa = true; // Mark the item as deleted
            existingItem.ThoiGianSua = DateTime.Now;
            existingItem.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
            _context.CT_ThongSo!.Update(existingItem);

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Return true to indicate successful deletion
            return true;
        }
    }
}
