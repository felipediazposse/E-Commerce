using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.ECommerceModels
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CommerceId { get; set; }
        public Commerce Commerce { get; set; } = new Commerce();
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
