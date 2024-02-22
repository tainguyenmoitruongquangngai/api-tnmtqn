using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Data.BC.KNTiepNhanNuocThai.KNTNNTSong;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class PhanDoanSongService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public PhanDoanSongService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<PhanDoanSongDto>> GetAllPhanDoanSongAsync()
        {
            var items = await _context.PhanDoanSong!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<PhanDoanSongDto>>(items);
        }

        public async Task<bool> SavePhanDoanSongAsync(PhanDoanSongDto dto)
        {
            var exitsItem = await _context!.PhanDoanSong!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<PhanDoanSong>(dto);

                _context.PhanDoanSong!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.PhanDoanSong!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.PhanDoanSong!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeletePhanDoanSongAsync(int Id)
        {
            var exitsItem = await _context!.PhanDoanSong!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.PhanDoanSong?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

