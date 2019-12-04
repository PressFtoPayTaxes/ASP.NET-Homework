using Microsoft.EntityFrameworkCore;

namespace Configurations.DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Name = "Admin",
                Login = "admin",
                Password = "123"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name = "Potato",
                Price = 2.00
            },
            new Product { 
                Name = "Tomato",
                Price = 3.99
            },
            new Product { 
                Name = "Table",
                Price = 10.00
            });
        }
    }
}
