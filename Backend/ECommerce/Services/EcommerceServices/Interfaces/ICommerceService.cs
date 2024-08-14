using ECommerce.Dtos.CommerceDtos;
using ECommerce.Models.ECommerceModels;

namespace ECommerce.Services.EcommerceServices.Interfaces
{
    public interface ICommerceService
    {
        Task<Commerce?> GetByIdAsync(int id);
        Task<IEnumerable<Commerce>> GetByNameAsync(string name);
        Task<IEnumerable<GetCommercesDto>> GetAllAsync();
        Task<Commerce> CreateAsync(CreateCommerceDto commerce);
        Task<Commerce> UpdateAsync(int id, Commerce commerce);
        Task<bool> DeleteAsync(int id);
    }
}
