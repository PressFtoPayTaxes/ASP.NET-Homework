using AspNetMvcCoreVsMvcFrameworkComparison2.Models;
using AspNetMVCCoreVsMVCFrameworkComparison2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspNetMvcCoreVsMvcFrameworkComparison2.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<WorkExample> WorksExamples { get; set; }
        public DbSet<Admin> Admins{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var portfolio = new Portfolio
            {
                FullName = "Скоропад Игорь",
                Achievements = "Красный подстаканник",
                Age = 17,
                EducationalInstitution = "Компьютерная Академия ШАГ",
                Email = "igor_2002_25@mail.ru",
                Job = "нет",
                WorkPlace = "нет"
            };

            var admin = new Admin
            {
                Login = "admin",
                Password = "123",
                PortfolioId = portfolio.Id
            };


            builder.Entity<Portfolio>().HasData(portfolio);
            builder.Entity<Admin>().HasData(admin);
            builder.Entity<WorkExample>().HasData(
                new WorkExample {
                    ImagePath = "~/img/examples/paris.jpg",
                    Portfolio = portfolio
                },
                new WorkExample
                {
                    ImagePath = "~/img/examples/Store.png",
                    Portfolio = portfolio
                },
                new WorkExample
                {
                    ImagePath = "~/img/examples/waxom.jpg",
                    Portfolio = portfolio
                }
            );
        }
    }
}
