using System.Collections.Generic;
using System;

namespace Myntra.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string UserId { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal ShippingAmount { get; set; }

        public string Status { get; set; } = "pending";
        public string PaymentStatus { get; set; } = "unpaid";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<OrderItem> Items { get; set; }
    }
}
