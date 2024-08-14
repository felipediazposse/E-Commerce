using ECommerce.Models.ECommerceModels;
using ECommerce.Repositories.ECommerceRepositories.Interfaces;
using ECommerce.Services.EcommerceServices.Interfaces;

namespace ECommerce.Services.EcommerceServices.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Product>> GetByNameAsync(string name)
        {
            return await _repository.GetByNameAsync(name);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product> CreateAsync(Product product)
        {
            return await _repository.CreateAsync(product);
        }

        public async Task<Product> UpdateAsync(int id, Product product)
        {
            var existingProduct = await _repository.GetByIdAsync(id);
            if (existingProduct == null)
                throw new Exception($"Product with id {id} not found");

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.UnitPrice = product.UnitPrice;
            existingProduct.Stock = product.Stock;
            existingProduct.CategoryId = product.CategoryId;

            return await _repository.UpdateAsync(existingProduct);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
