using ECommerce.Models.ECommerceModels;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Dtos.CommerceDtos
{
    public class GetCommercesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public string ProfilePictureLQ { get; set; } = string.Empty;
    }
}
