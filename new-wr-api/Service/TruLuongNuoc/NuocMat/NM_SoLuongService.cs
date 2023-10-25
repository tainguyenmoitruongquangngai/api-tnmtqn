using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class NM_SoLuongService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public NM_SoLuongService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<TLN_NuocMat_SoLuongDto>> GetAllAsync()
        {
            var items = await _context.TLN_NuocMat_SoLuong!.Where(d => d.DaXoa == false)
                .Include(d => d.Song)
                .OrderBy(d => d.Id)
                .AsQueryable().ToListAsync();

            var soLuongNuocMatDto = _mapper.Map<List<TLN_NuocMat_SoLuongDto>>(items);
            foreach (var dto in soLuongNuocMatDto)
            {
                if (!string.IsNullOrEmpty(dto.Song!.IdXaDauSong.ToString()))
                {
                    var ds = await _context.DonViHC!.FirstOrDefaultAsync(dv => dv.IdXa == dto.Song!.IdXaDauSong.ToString());
                    if (ds != null)
                    {
                        dto.Song.DauSong = new DauCuoiSongDto
                        {
                            X = dto.Song.XDauSong,
                            Y = dto.Song.YDauSong,
                            Xa = ds!.TenXa,
                            Huyen = ds!.TenHuyen
                        };
                    }
                    var cs = await _context.DonViHC!.FirstOrDefaultAsync(dv => dv.IdXa == dto.Song!.IdXaCuoiSong.ToString());
                    if (cs != null)
                    {
                        dto.Song.CuoiSong = new DauCuoiSongDto
                        {
                            X = dto.Song.XCuoiSong,
                            Y = dto.Song.YCuoiSong,
                            Xa = cs!.TenXa,
                            Huyen = cs!.TenHuyen
                        };
                    }
                }
            }
            return soLuongNuocMatDto;


        }
        public async Task<bool> SaveAsync(TLN_NuocMat_SoLuongDto dto)
        {

            var existingItem = await _context.TLN_NuocMat_SoLuong!.FirstOrDefaultAsync(d => d.Id == dto.Id && d.DaXoa == false);

            if (existingItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<TLN_NuocMat_SoLuong>(dto);
                newItem.DaXoa = false;
                newItem.ThoiGianTao = DateTime.Now;
                newItem.TaiKhoanTao = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.TLN_NuocMat_SoLuong!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.TLN_NuocMat_SoLuong!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);

                updateItem!.ThoiGianSua = DateTime.Now;
                updateItem.TaiKhoanSua = _httpContext.HttpContext?.User.FindFirstValue(ClaimTypes.Name) ?? null;
                _context.TLN_NuocMat_SoLuong!.Update(updateItem);
            }

            var res = await _context.SaveChangesAsync();

            return true;
        }


        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.TLN_NuocMat_SoLuong!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.TLN_NuocMat_SoLuong!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
