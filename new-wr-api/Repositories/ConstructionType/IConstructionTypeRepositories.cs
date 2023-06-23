using new_wr_api.Models;

namespace new_wr_api.Repositories.ConstructionType
{
    public interface IConstructionTypeRepositories
    {
        public Task<List<ConstructionTypeModel>> GetAllConstructionTypeAsync();
        public Task<ConstructionTypeModel> GetConstructionTypeAsync(int Id);
        public Task<bool> CreateConstructionTypeAsync(ConstructionTypeModel model);
        public Task<bool> UpdateConstructionTypeAsync(int Id, ConstructionTypeModel model);
        public Task<bool> DeleteConstructionTypeAsync(int Id);
    }
}
