﻿using System.Collections.Generic;
using System;

namespace Myntra.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public string UserId { get; set; }

        public ICollection<CartItem> Items { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
