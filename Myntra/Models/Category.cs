using System.Collections.Generic;

namespace Myntra.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public int? ParentId { get; set; }
        public Category Parent { get; set; }
        public ICollection<Category> Children { get; set; }

        public int SortOrder { get; set; } = 0;
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
