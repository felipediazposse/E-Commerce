using AutoMapper;
using ECommerce.Dtos.CommerceDtos;
using ECommerce.Models.ECommerceModels;
using ECommerce.Repositories.ECommerceRepositories.Interfaces;
using ECommerce.Services.EcommerceServices.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Services.EcommerceServices.Implementation
{
    public class CommerceService : ICommerceService
    {
        private readonly ICommerceRepository _repository;
        private readonly IMapper _mapper;

        public CommerceService(ICommerceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Commerce?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Commerce>> GetByNameAsync(string name)
        {
            return await _repository.GetByNameAsync(name);
        }

        public async Task<IEnumerable<GetCommercesDto>> GetAllAsync()
        {
            var commerces = await _repository.GetAllAsync();
            var commercesDto = _mapper.Map<List<GetCommercesDto>>(commerces);
            return commercesDto;
        }

        public async Task<Commerce> CreateAsync(CreateCommerceDto commerceDto)
        {
            Commerce commerce = _mapper.Map<Commerce>(commerceDto);
            return await _repository.CreateAsync(commerce);
        }

        public async Task<Commerce> UpdateAsync(int id, Commerce commerce)
        {
            var existingCommerce = await _repository.GetByIdAsync(id);
            if (existingCommerce == null)
                throw new Exception($"Commerce with id {id} not found");

            existingCommerce.Name = commerce.Name;
            existingCommerce.Description = commerce.Description;
            existingCommerce.PhoneNumber = commerce.PhoneNumber;
            existingCommerce.AddressId = commerce.AddressId;
            existingCommerce.Address = commerce.Address;
            existingCommerce.ProfilePictureHQ = commerce.ProfilePictureHQ;
            existingCommerce.ProfilePictureLQ = commerce.ProfilePictureLQ;
            existingCommerce.CoverPicture = commerce.CoverPicture;

            return await _repository.UpdateAsync(existingCommerce);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
