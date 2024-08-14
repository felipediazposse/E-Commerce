namespace ECommerce.Models.ECommerceModels
{
    public class Cart
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public List<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
