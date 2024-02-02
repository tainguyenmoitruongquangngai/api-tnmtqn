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
            CT_ThongSo? item = null; // Declare item variable

            // Retrieve an existing item based on Id or if dto.Id is 0
            var existingItem = await _context.CT_ThongSo!.FirstOrDefaultAsync(d => d.IdCT == dto.IdCT || d.IdHangMucCT == dto.IdHangMucCT);

            if (existingItem == null)
            {
                // If the item doesn't exist or dto.Id is 0, create a new item
                item = _mapper.Map<CT_ThongSo>(dto);
                if (item.IdCT == 0) item.IdCT = null;
                if (item.IdHangMucCT == 0) item.IdHangMucCT = null;
                item.DaXoa = false;
                item.ThoiGianTao = DateTime.Now;
                item.TaiKhoanTao = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongSo!.Add(item);
            }
            else
            {
                // If the item exists, update it with values from the dto, excluding the key property
                item = existingItem;
                _mapper.Map(dto, item);
                if (item.IdCT == 0) item.IdCT = null;
                if (item.IdHangMucCT == 0) item.IdHangMucCT = null;
                item.DaXoa = false;
                item.ThoiGianSua = DateTime.Now;
                item.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.CT_ThongSo!.Update(item);
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
