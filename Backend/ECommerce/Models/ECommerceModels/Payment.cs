namespace ECommerce.Models.ECommerceModels
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentStatusId { get; set; }
        public PaymentStatus PaymentStatus { get; set; } = new PaymentStatus();
        public string TransactionId { get; set; } = string.Empty;
    }
}
