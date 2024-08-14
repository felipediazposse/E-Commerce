using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.ECommerceModels
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
        public List<CartItem>? CartItems { get; set; }
    }
}
