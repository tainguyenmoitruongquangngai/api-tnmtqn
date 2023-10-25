using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class BieuMauMuoiBonService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BieuMauMuoiBonService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BieuMauMuoiBonDto>> GetAllBieuMauMuoiBonAsync()
        {
            var items = await _context.BieuMauSoMuoiBon!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<BieuMauMuoiBonDto>>(items);
        }

        public async Task<bool> SaveBieuMauMuoiBonAsync(BieuMauMuoiBonDto dto)
        {
            var exitsItem = await _context!.BieuMauSoMuoiBon!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<BieuMauSoMuoiBon>(dto);

                _context.BieuMauSoMuoiBon!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.BieuMauSoMuoiBon!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.BieuMauSoMuoiBon!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBieuMauMuoiBonAsync(int Id)
        {
            var exitsItem = await _context!.BieuMauSoMuoiBon!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.BieuMauSoMuoiBon?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

