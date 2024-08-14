namespace ECommerce.Models.ECommerceModels
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public DateTime OrderDate { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; } = new OrderStatus();
        public decimal TotalAmount { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public int PaymentId { get; set; }
        public Payment Payment { get; set; } = new Payment();
    }
}
