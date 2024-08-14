using AutoMapper;
using ECommerce.Dtos.CommerceDtos;
using ECommerce.Models.ECommerceModels;

namespace ECommerce.Mappers
{
    public class CommerceMapper : Profile
    {
        public CommerceMapper() 
        {
            CreateMap<CreateCommerceDto, Commerce>();
            CreateMap<Commerce, GetCommercesDto>();
            CreateMap<Commerce, GetCommerceByIdDto>();
        }
    }
}
