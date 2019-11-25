using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                Price = 120.00
            },
            new Product { 
                Name = "Tomato",
                Price = 156.23
            },
            new Product { 
                Name = "Table",
                Price = 23455.00
            });
        }
    }
}
