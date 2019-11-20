using ControlWork.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWork.DataAccess
{
    public class TaxiContext : DbContext
    {
        public TaxiContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-205-10;Database=Taxi;Trusted_Connection=true;");
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers{ get; set; }
        public DbSet<Order> Orders{ get; set; }
    }
}
