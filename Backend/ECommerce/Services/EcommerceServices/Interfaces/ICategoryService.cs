using ECommerce.Models.ECommerceModels;

namespace ECommerce.Services.EcommerceServices.Interfaces
{
    public interface ICategoryService
    {
        Task<Category?> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetByNameAsync(string name);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(int id, Category category);
        Task<bool> DeleteAsync(int id);
    }
}
