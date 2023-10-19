using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class BieuMauMuoiNamService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BieuMauMuoiNamService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BieuMauMuoiNamDto>> GetAllBieuMauMuoiNamAsync()
        {
            var items = await _context.BieuMauSoMuoiNam!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<BieuMauMuoiNamDto>>(items);
        }

        public async Task<bool> SaveBieuMauMuoiNamAsync(BieuMauMuoiNamDto dto)
        {
            var exitsItem = await _context!.BieuMauSoMuoiNam!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<BieuMauSoMuoiNam>(dto);

                _context.BieuMauSoMuoiNam!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.BieuMauSoMuoiNam!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.BieuMauSoMuoiNam!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBieuMauMuoiNamAsync(int Id)
        {
            var exitsItem = await _context!.BieuMauSoMuoiNam!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.BieuMauSoMuoiNam?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

