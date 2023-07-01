using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories.ConstructionType
{
    public class ConstructionTypeRepositories : IConstructionTypeRepositories
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public ConstructionTypeRepositories(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateConstructionTypeAsync(ConstructionTypeModel model)
        {
            var newCons = _mapper.Map<Data.ConstructionType>(model);
            var currentDate = DateTime.Now;
            newCons.IsDeleted = false;
            newCons.Status = true;
            newCons.CreatedTime = currentDate;
            _context.ConstructionType!.Add(newCons);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteConstructionTypeAsync(int Id)
        {
            var construction = await _context.ConstructionType!.FindAsync(Id);
            if (Id == construction!.Id)
            {
                var currentDate = DateTime.Now;
                construction.IsDeleted = true;
                construction.ModifiedTime = currentDate;
                _context.ConstructionType!.Update(construction);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<ConstructionTypeModel> GetConstructionTypeAsync(int id)
        {
            var construction = await _context.ConstructionType!.FindAsync(id);
            return _mapper.Map<ConstructionTypeModel>(construction);
        }

        public async Task<List<ConstructionTypeModel>> GetAllConstructionTypeAsync()
        {
            var construction = await _context.ConstructionType!.Where(e => e.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<ConstructionTypeModel>>(construction);
        }

        public async Task<bool> UpdateConstructionTypeAsync(int id, ConstructionTypeModel model)
        {
            var construction = await _context.ConstructionType!.FindAsync(id);
            if (construction == null) return false;

            var currentDate = DateTime.Now;
            construction.ModifiedTime = currentDate;

            _mapper.Map(model, construction);

            await _context.SaveChangesAsync();

            return true;
        }

    }
}
