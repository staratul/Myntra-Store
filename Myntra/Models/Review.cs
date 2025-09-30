using System;

namespace Myntra.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string UserId { get; set; }
        public int Rating { get; set; }

        public string Title { get; set; }
        public string Comment { get; set; }

        public string Status { get; set; } = "pending";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
