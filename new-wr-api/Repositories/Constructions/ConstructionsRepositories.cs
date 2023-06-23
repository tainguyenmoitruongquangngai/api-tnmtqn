using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories.Constructions
{
    public class ConstructionsRepositories : IConstructionsRepositories
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public ConstructionsRepositories(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateConstructionAsync(ConstructionsModel model)
        {
            var newCons = _mapper.Map<Data.Constructions>(model);
            var currentDate = DateTime.Now;
            newCons.IsDeleted = false;
            newCons.CreatedTime = currentDate;
            _context.Constructions!.Add(newCons);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteConstructionAsync(int Id)
        {
            var construction = await _context.Constructions!.FindAsync(Id);
            if (Id == construction!.Id)
            {
                var currentDate = DateTime.Now;
                construction.IsDeleted = true;
                construction.ModifiedTime = currentDate;
                _context.Constructions!.Update(construction);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<ConstructionsModel> GetConstructionAsync(int id)
        {
            var construction = await _context.Constructions!.FindAsync(id);
            return _mapper.Map<ConstructionsModel>(construction);
        }

        public async Task<List<ConstructionsModel>> GetAllConstructionsAsync()
        {
            var construction = await _context.Constructions!.Where(e => e.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<ConstructionsModel>>(construction);
        }

        public async Task<bool> UpdateConstructionAsync(int id, ConstructionsModel model)
        {
            var construction = await _context.Constructions!.FindAsync(id);
            if (construction == null) return false;

            var currentDate = DateTime.Now;
            construction.IsDeleted = false;
            construction.ModifiedTime = currentDate;

            _mapper.Map(model, construction);

            await _context.SaveChangesAsync();

            return true;
        }

    }
}
