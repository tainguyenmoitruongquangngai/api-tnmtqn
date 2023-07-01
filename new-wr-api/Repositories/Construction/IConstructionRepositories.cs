using new_wr_api.Models;

namespace new_wr_api.Repositories.Construction
{
    public interface IConstructionRepositories
    {
        public Task<List<ConstructionModel>> GetAllConstructionAsync();
        public Task<ConstructionModel> GetConstructionAsync(int Id);
        public Task<bool> CreateConstructionAsync(ConstructionModel model);
        public Task<bool> UpdateConstructionAsync(int Id, ConstructionModel model);
        public Task<bool> DeleteConstructionAsync(int Id);
    }
}
