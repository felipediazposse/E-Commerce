using Microsoft.AspNetCore.Identity;

namespace ECommerce.Models.ECommerceModels
{
    public class Commerce
    {
        public int Id { get; set; }
        public string IdentityUserId { get; set; } = string.Empty;
        public IdentityUser IdentityUser { get; set; } = new IdentityUser();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int AddressId { get; set; }
        public Address Address { get; set; } = new Address();
        public string ProfilePictureHQ { get; set; } = string.Empty;
        public string ProfilePictureLQ { get; set; } = string.Empty;
        public string CoverPicture { get; set; } = string.Empty;
        public List<Category> Categories { get; set; } = new List<Category>();
        public bool IsActive { get; set; } = true;
    }
}