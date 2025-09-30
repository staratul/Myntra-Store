using System.Collections.Generic;

namespace Myntra.Models
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Sku { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }

        public string Size { get; set; }
        public string Color { get; set; }
        public int StockQty { get; set; }
        public double Weight { get; set; }

        public ICollection<ProductImage> Images { get; set; }
    }
}
