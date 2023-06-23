using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories.Licenses
{
    public class LicensesRepositories : ILicensesRepositories
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public LicensesRepositories(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateLicenseAsync(LicensesModel model)
        {
            var newCons = _mapper.Map<Data.Licenses>(model);
            var currentDate = DateTime.Now;
            newCons.IsDeleted = false;
            newCons.CreatedTime = currentDate;
            _context.Licenses!.Add(newCons);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteLicenseAsync(int Id)
        {
            var license = await _context.Licenses!.FindAsync(Id);
            if (Id == license!.Id)
            {
                var currentDate = DateTime.Now;
                license.IsDeleted = true;
                license.ModifiedTime = currentDate;
                _context.Licenses!.Update(license);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<LicensesModel> GetLicenseAsync(int id)
        {
            var license = await _context.Licenses!.FindAsync(id);
            return _mapper.Map<LicensesModel>(license);
        }

        public async Task<List<LicensesModel>> GetAllLicensesAsync()
        {
            var license = await _context.Licenses!.Where(e => e.IsDeleted == false).ToListAsync();
            return _mapper.Map<List<LicensesModel>>(license);
        }

        public async Task<bool> UpdateLicenseAsync(int id, LicensesModel model)
        {
            var license = await _context.Licenses!.FindAsync(id);
            if (license == null) return false;

            var currentDate = DateTime.Now;
            license.IsDeleted = false;
            license.ModifiedTime = currentDate;

            _mapper.Map(model, license);

            await _context.SaveChangesAsync();

            return true;
        }

    }
}
