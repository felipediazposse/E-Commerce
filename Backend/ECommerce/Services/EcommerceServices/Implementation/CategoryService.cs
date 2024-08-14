using ECommerce.Models.ECommerceModels;
using ECommerce.Repositories.ECommerceRepositories.Interfaces;
using ECommerce.Services.EcommerceServices.Interfaces;

namespace ECommerce.Services.EcommerceServices.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Category>> GetByNameAsync(string name)
        {
            return await _repository.GetByNameAsync(name);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> CreateAsync(Category category)
        {
            return await _repository.CreateAsync(category);
        }

        public async Task<Category> UpdateAsync(int id, Category category)
        {
            var existingCategory = await _repository.GetByIdAsync(id);
            if (existingCategory == null)
                throw new Exception($"Category with id {id} not found");

            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;
            existingCategory.CommerceId = category.CommerceId;

            return await _repository.UpdateAsync(existingCategory);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
