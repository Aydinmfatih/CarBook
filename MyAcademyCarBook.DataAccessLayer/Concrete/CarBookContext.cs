using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Concrete
{
    public class CarBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;initial catalog = CarBookDb;integrated Security = true");
            
        }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarCategory> CarCategories { get; set; }

        public DbSet<CarStatus> CarStatuses { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Price> Prices { get; set; }
    }
}
