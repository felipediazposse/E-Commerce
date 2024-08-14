using ECommerce.Models.ECommerceModels;

namespace ECommerce.Repositories.ECommerceRepositories.Interfaces
{
    public interface ICommerceRepository
    {
        Task<Commerce?> GetByIdAsync(int id);
        Task<IEnumerable<Commerce>> GetByNameAsync(string name);
        Task<IEnumerable<Commerce>> GetAllAsync();
        Task<Commerce> CreateAsync(Commerce commerce);
        Task<Commerce> UpdateAsync(Commerce commerce);
        Task<bool> DeleteAsync(int id);
    }
}
