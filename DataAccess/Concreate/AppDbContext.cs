using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ReCapProject;User ID=sa;Password=Password12*;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().HasData(

                 new Color
                 {
                     Id = 1,
                     Name = "Black",
                 },
                 new Color
                 {
                     Id = 2,
                     Name = "White",
                 });

            modelBuilder.Entity<Brand>().HasData(

                new Brand
                {
                    Id = 1,
                    Name = "Renault"
                },

                new Brand
                {
                    Id = 2,
                    Name = "Audi"
                });

            modelBuilder.Entity<Car>().HasData(

                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 1,
                    DailyPrice = 100000,
                    ModelYear = "2023",
                    Description = "Hatchback"
                },
                new Car
                {
                    Id = 2,
                    BrandId = 2,
                    ColorId = 1,
                    DailyPrice = 125000,
                    ModelYear = "2022",
                    Description = "Sedan"
                });

            modelBuilder.Entity<Customer>().HasData(

                new Customer
                {
                    Id = 1,
                    CompanyName = "Agartha"
                });


            modelBuilder.Entity<User>().HasData(

                new User
                {
                    Id = 1,
                    CustomerId = 1,
                    FirstName = "Yahya",
                    LastName = "Karayel",
                    Email = "karayelyahya@gmail.com",
                    Password = "Password12*"
                },
                new User
                {
                    Id = 2,
                    CustomerId = 1,
                    FirstName = "Ahmet",
                    LastName = "Karayel",
                    Email = "ahmetkarayel@gmail.com",
                    Password = "Password12*"
                });






            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Rental> Rentals { get; set; }


    }
}
