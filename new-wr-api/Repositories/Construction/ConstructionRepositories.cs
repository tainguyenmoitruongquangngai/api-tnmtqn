using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories.Construction
{
    public class ConstructionRepositories : IConstructionRepositories
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public ConstructionRepositories(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ConstructionModel>> GetAllConstructionAsync()
        {
            var construction = await _context.Construction!.Where(e => e.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<ConstructionModel>>(construction);
        }

        public async Task<ConstructionModel> GetConstructionAsync(int id)
        {
            var construction = await _context.Construction!.FindAsync(id);
            return _mapper.Map<ConstructionModel>(construction);
        }
        public async Task<bool> CreateConstructionAsync(ConstructionModel model)
        {
            var newCons = _mapper.Map<Data.Construction>(model);
            var currentDate = DateTime.Now;
            newCons.IsDeleted = false;
            newCons.Status = true;
            newCons.CreatedTime = currentDate;
            _context.Construction!.Add(newCons);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateConstructionAsync(int id, ConstructionModel model)
        {
            var construction = await _context.Construction!.FindAsync(id);
            if (construction == null) return false;

            var currentDate = DateTime.Now;

            construction.ModifiedTime = currentDate;

            _mapper.Map(model, construction);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteConstructionAsync(int Id)
        {
            var construction = await _context.Construction!.FindAsync(Id);
            if (Id == construction!.Id)
            {
                var currentDate = DateTime.Now;
                construction.IsDeleted = true;
                construction.ModifiedTime = currentDate;
                _context.Construction!.Update(construction);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
