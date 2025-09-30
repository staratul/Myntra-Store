namespace Myntra.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }

        public int Qty { get; set; }
        public decimal PriceAtTime { get; set; }
    }
}
