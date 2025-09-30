namespace Myntra.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }

        public string Url { get; set; }
        public int SortOrder { get; set; }
    }
}
