using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class BieuMauMuoiService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BieuMauMuoiService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BieuMauMuoiDto>> GetAllBieuMauMuoiAsync()
        {
            var items = await _context.BieuMauSoMuoi!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<BieuMauMuoiDto>>(items);
        }

        public async Task<bool> SaveBieuMauMuoiAsync(BieuMauMuoiDto dto)
        {
            var exitsItem = await _context!.BieuMauSoMuoi!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<BieuMauSoMuoi>(dto);

                _context.BieuMauSoMuoi!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.BieuMauSoMuoi!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.BieuMauSoMuoi!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBieuMauMuoiAsync(int Id)
        {
            var exitsItem = await _context!.BieuMauSoMuoi!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.BieuMauSoMuoi?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

