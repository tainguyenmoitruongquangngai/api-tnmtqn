using new_wr_api.Models;

namespace new_wr_api.Repositories.Constructions
{
    public interface IConstructionsRepositories
    {
        public Task<List<ConstructionsModel>> GetAllConstructionsAsync();
        public Task<ConstructionsModel> GetConstructionAsync(int Id);
        public Task<bool> CreateConstructionAsync(ConstructionsModel model);
        public Task<bool> UpdateConstructionAsync(int Id, ConstructionsModel model);
        public Task<bool> DeleteConstructionAsync(int Id);
    }
}
