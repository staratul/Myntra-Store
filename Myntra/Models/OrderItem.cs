namespace Myntra.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }

        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
    }
}
