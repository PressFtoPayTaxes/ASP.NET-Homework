using System;
using System.Collections.Generic;
using System.Text;
using AspNetMVCCoreVsMVCFrameworkComparison.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetMVCCoreVsMVCFrameworkComparison.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Portfolio>().HasData(new Portfolio
            {
                FullName = "Скоропад Игорь",
                Achievements = "Красный подстаканник",
                Age = 17,
                EducationalInstitution = "Компьютерная Академия ШАГ",
                Email = "igor_2002_25@mail.ru",
                Job = "нет",
                WorkExamples = new List<string>
                {
                    "./wwwroot/img/examples/paris.jpg",
                    "./wwwroot/img/examples/waxom.jpg",
                    "./wwwroot/img/examples/Store.png"
                },
                WorkPlace = "нет"
            });

            builder.Entity<Admin>().HasData(new Admin
            {
                Login = "admin",
                Password = "123"
            });
        }
    }
}
