using Microsoft.EntityFrameworkCore;
using Myntra.Models;

namespace Myntra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Children)
                .WithOne(c => c.Parent)
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Set decimal precision for all money-related fields
            modelBuilder.Entity<ProductVariant>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ProductVariant>()
                .Property(p => p.SalePrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(p => p.Discount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(p => p.Tax)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(p => p.ShippingAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(p => p.TotalAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<CartItem>()
                .Property(p => p.PriceAtTime)
                .HasPrecision(18, 2);
        }
    }
}
