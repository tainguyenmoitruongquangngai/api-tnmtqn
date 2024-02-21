using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class DuLieuNguonNuocNhanService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public DuLieuNguonNuocNhanService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<DuLieuNguonNuocNhanDto>> GetAllDulieuNguonNuocNhanAsync()
        {
            var items = await _context.DuLieuNguonNuocNhan!.Where(x => x.Id > 0).ToListAsync();
            return _mapper.Map<List<DuLieuNguonNuocNhanDto>>(items);
        }

        public async Task<bool> SaveDulieuNguonNuocNhanAsync(DuLieuNguonNuocNhanDto dto)
        {
            var exitsItem = await _context!.DuLieuNguonNuocNhan!.FindAsync(dto.Id);

            if (exitsItem == null || dto.Id == 0)
            {
                var newItem = _mapper.Map<DuLieuNguonNuocNhan>(dto);

                _context.DuLieuNguonNuocNhan!.Add(newItem);
            }
            else
            {
                var updateItem = await _context.DuLieuNguonNuocNhan!.FirstOrDefaultAsync(d => d.Id == dto.Id);

                updateItem = _mapper.Map(dto, updateItem);
                _context.DuLieuNguonNuocNhan!.Update(updateItem!);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteDulieuNguonNuocNhanAsync(int Id)
        {
            var exitsItem = await _context!.DuLieuNguonNuocNhan!.FirstOrDefaultAsync(d => d.Id == Id);

            if (exitsItem == null) { return false; }

            _context.DuLieuNguonNuocNhan?.Remove(exitsItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

