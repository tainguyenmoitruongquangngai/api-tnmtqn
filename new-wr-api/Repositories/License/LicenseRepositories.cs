using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Repositories.License
{
    public class LicenseRepositories : ILicenseRepositories
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public LicenseRepositories(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateLicenseAsync(LicenseModel model)
        {
            var newLicense = _mapper.Map<Data.License>(model);
            var currentDate = DateTime.Now;
            newLicense.IsDeleted = false;
            newLicense.Status = true;
            newLicense.CreatedTime = currentDate;
            _context.License!.Add(newLicense);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteLicenseAsync(int Id)
        {
            var license = await _context.License!.FindAsync(Id);
            if (Id == license!.Id)
            {
                var currentDate = DateTime.Now;
                license.IsDeleted = true;
                license.ModifiedTime = currentDate;
                _context.License!.Update(license);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<LicenseModel> GetLicenseAsync(int id)
        {
            var license = await _context.License!.FindAsync(id);

            return _mapper.Map<LicenseModel>(license);
        }

        public async Task<List<LicenseModel>> GetAllLicenseAsync()
        {
            var license = await _context.License!.Where(e => e.IsDeleted == false).ToListAsync();

            return _mapper.Map<List<LicenseModel>>(license);
        }

        public async Task<bool> UpdateLicenseAsync(int id, LicenseModel model)
        {
            var license = await _context.License!.FindAsync(id);
            _mapper.Map(model, license);

            if (license == null) return false;

            var currentDate = DateTime.Now;
            license.ModifiedTime = currentDate;
            _context.License!.Update(license);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
