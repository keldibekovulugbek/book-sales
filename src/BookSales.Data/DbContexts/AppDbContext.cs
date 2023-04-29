
using BookSales.Domain.Entities.Orders;
using BookSales.Domain.Entities.Products;
using BookSales.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BookSales.DataAccess.DBContexts
{
    public class AppDbContext : DbContext
    {

        public virtual DbSet<User> Users { get; set; } = default!;

        public virtual DbSet<Author> Authors { get; set; } = default!;
        
        public virtual DbSet<Category> Categories { get; set; } = default!;
        
        public virtual DbSet<Feedback> Feedbacks { get; set; } = default!;
        
        public virtual DbSet<NestedCategory> NestedCategories { get; set; } = default!;
        
        public virtual DbSet<Product> Products { get; set; } = default!;
        
        public virtual DbSet<CartItem> CartItems { get; set; } = default!;
        
        public virtual DbSet<Order> Orders { get; set; } = default!;
        
        public virtual DbSet<Payment> Payments { get; set; } = default!;
        
        public virtual DbSet<Session> Sessions { get; set; } = default!;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
