using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class BieuMauMuoiBaService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BieuMauMuoiBaService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BieuMauMuoiBaDto>> GetAllBieuMauMuoiBaAsync()
        {
            var items = await _context.BieuMauSoMuoiBa!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<BieuMauMuoiBaDto>>(items);
        }

        public async Task<bool> SaveBieuMauMuoiBaAsync(BieuMauMuoiBaDto dto)
        {
            var exitsItem = await _context!.BieuMauSoMuoiBa!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<BieuMauSoMuoiBa>(dto);

                _context.BieuMauSoMuoiBa!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.BieuMauSoMuoiBa!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.BieuMauSoMuoiBa!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBieuMauMuoiBaAsync(int Id)
        {
            var exitsItem = await _context!.BieuMauSoMuoiBa!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.BieuMauSoMuoiBa?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

