using ECommerce.Models;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Dtos.CommerceDtos
{
    public class CreateCommerceDto
    {
        public string IdentityUserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int AddressId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ProfilePictureHQ { get; set; } = string.Empty;
        public string ProfilePictureLQ { get; set; } = string.Empty;
        public string CoverPicture { get; set; } = string.Empty;
    }
}
