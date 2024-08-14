using Microsoft.AspNetCore.Identity;

namespace ECommerce.Models.ECommerceModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string IdentityUserId { get; set; } = string.Empty;
        public IdentityUser? IdentityUser { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Cart Cart { get; set; } = new Cart();
        public int CartId { get; set; }
    }
}
