using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class DonViHCService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AspNetUsers> _userManager;

        public DonViHCService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
        }

        public async Task<List<DonViHCDto>> GetAllAsync()
        {
            var items = await _context!.DonViHC!
                .Where(x => x.DaXoa == false)
                .OrderBy(x => x.TenHuyen)
                .ToListAsync();

            var listItems = _mapper.Map<List<DonViHCDto>>(items);
            return listItems;
        }

        public async Task<List<HuyenDto>> GetAllDistrictAsync()
        {
            var items = await _context.Huyen!
                .Where(l => l.DaXoa == false)
                .ToListAsync();

            var listItems = _mapper.Map<List<HuyenDto>>(items);
            return listItems;
        }

        public async Task<List<XaDto>> GetAllCommuneAsync()
        {
            var items = await _context.Xa!
                .Where(l => l.DaXoa == false)
                .ToListAsync();

            var listItems = _mapper.Map<List<XaDto>>(items);
            return listItems;
        }

        public async Task<List<XaDto>> GetAllCommuneByDistrictAsync(string IdHuyen)
        {
            var items = await _context.Xa!
                .Where(l => l.IdHuyen == IdHuyen && l.DaXoa == false)
                .ToListAsync();

            var listItems = _mapper.Map<List<XaDto>>(items);
            return listItems;
        }

        public async Task<DonViHCDto?> GetByIdAsync(int Id)
        {
            var item = await _context.DonViHC!.FindAsync(Id);
            return _mapper.Map<DonViHCDto>(item);
        }


        public async Task<bool> SaveAsync(DonViHCDto model)
        {
            var existingItem = await _context.DonViHC!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);

            if (existingItem == null || model.Id == 0)
            {
                var newItem = _mapper.Map<DonViHC>(model);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = currentUser != null ? currentUser.UserName : null;
                _context.DonViHC!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.DonViHC!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);

                updateItem = _mapper.Map(model, updateItem);
                updateItem!.DaXoa = false;
                updateItem.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.DonViHC!.Update(updateItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.DonViHC!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);

            if (existingItem == null) { return false; } // If the item doesn't exist, return false

            existingItem!.DaXoa = true; // Mark the item as deleted
            existingItem.ThoiGianSua = DateTime.Now;
            existingItem.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
            _context.DonViHC!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
