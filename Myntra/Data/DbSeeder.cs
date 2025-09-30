using Microsoft.EntityFrameworkCore;
using Myntra.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Myntra.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(AppDbContext db)
        {
            if (!db.Categories.Any(c => c.Slug == "men"))
            {
                var men = new Category { Name = "Men", Slug = "men" };
                var women = new Category { Name = "Women", Slug = "women" };
                var kids = new Category { Name = "Kids", Slug = "kids" };

                db.Categories.AddRange(men, women, kids);
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                    throw;
                }

                db.Categories.AddRange(
                    new Category { Name = "T-Shirts", Slug = "t-shirts", ParentId = men.Id },
                    new Category { Name = "Jeans", Slug = "jeans", ParentId = men.Id },
                    new Category { Name = "Shirts", Slug = "shirts", ParentId = men.Id },

                    new Category { Name = "Sarees", Slug = "sarees", ParentId = women.Id },
                    new Category { Name = "Dresses", Slug = "dresses", ParentId = women.Id },

                    new Category { Name = "Kids T-Shirts", Slug = "kids-tshirts", ParentId = kids.Id },
                    new Category { Name = "Kids Jeans", Slug = "kids-jeans", ParentId = kids.Id }
                );

                try
                {
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                    throw;
                }
            }

            if (!db.Brands.Any(b => b.Slug == "brand-a"))
            {
                db.Brands.AddRange(
                    new Brand { Name = "BrandA", Slug = "brand-a" },
                    new Brand { Name = "BrandB", Slug = "brand-b" }
                );
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                    throw;
                }
            }
        }
    }

}
