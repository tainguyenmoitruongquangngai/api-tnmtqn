using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class BieuMauMuoiMotService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BieuMauMuoiMotService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BieuMauMuoiMotDto>> GetAllBieuMauMuoiMotAsync()
        {
            var items = await _context.BieuMauSoMuoiMot!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<BieuMauMuoiMotDto>>(items);
        }

        public async Task<bool> SaveBieuMauMuoiMotAsync(BieuMauMuoiMotDto dto)
        {
            var exitsItem = await _context!.BieuMauSoMuoiMot!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<BieuMauSoMuoiMot>(dto);

                _context.BieuMauSoMuoiMot!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.BieuMauSoMuoiMot!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.BieuMauSoMuoiMot!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBieuMauMuoiMotAsync(int Id)
        {
            var exitsItem = await _context!.BieuMauSoMuoiMot!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.BieuMauSoMuoiMot?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

