using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class BieuMauMuoiHaiService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BieuMauMuoiHaiService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BieuMauMuoiHaiDto>> GetAllBieuMauMuoiHaiAsync()
        {
            var items = await _context.BieuMauSoMuoiHai!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<BieuMauMuoiHaiDto>>(items);
        }

        public async Task<bool> SaveBieuMauMuoiHaiAsync(BieuMauMuoiHaiDto dto)
        {
            var exitsItem = await _context!.BieuMauSoMuoiHai!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<BieuMauSoMuoiHai>(dto);

                _context.BieuMauSoMuoiHai!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.BieuMauSoMuoiHai!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.BieuMauSoMuoiHai!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteBieuMauMuoiHaiAsync(int Id)
        {
            var exitsItem = await _context!.BieuMauSoMuoiHai!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.BieuMauSoMuoiHai?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

