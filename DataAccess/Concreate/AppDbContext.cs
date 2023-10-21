using Core.Entities.Concrete;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess.Concreate
{
	public class AppDbContext : DbContext
	{
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Car> Cars { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Rental> Rentals { get; set; }
		public DbSet<CarImage> CarImages { get; set; }
		public DbSet<OperationClaim> OperationClaims { get; set; }
		public DbSet<UserOperationClaim> UserOperationsClaims { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ReCapProject;User ID=sa;Password=Password12*;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			//modelBuilder.Entity<Customer>().HasData(
			//	new Customer { Id = 1, CompanyName = "Agartha" },
			//	new Customer { Id = 2, CompanyName = "Tübitak" },
			//	new Customer { Id = 3, CompanyName = "Aselsan" },
			//	new Customer { Id = 4, CompanyName = "Erdemir" },
			//	new Customer { Id = 5, CompanyName = "Kardemir" });


			modelBuilder.Entity<Rental>().HasData(
				new Rental { Id = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now, CustormerId = 1, CarId = 1 },
				new Rental { Id = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now, CustormerId = 2, CarId = 4 },
				new Rental { Id = 3, RentDate = DateTime.Now, ReturnDate = DateTime.Now, CustormerId = 5, CarId = 6 });
	

			modelBuilder.Entity<Car>().HasData(
				new Car { Id = 1, BrandId = 2, DailyPrice = 100000, ModelYear = 2023, ColorId = 1, Description = "Hatchback"},
				new Car { Id = 2, BrandId = 5, DailyPrice = 125000, ModelYear = 2023, ColorId = 2, Description = "Hatchback" },
				new Car { Id = 3, BrandId = 1, DailyPrice = 115000, ModelYear = 2022, ColorId = 5, Description = "Sedan" },
				new Car { Id = 4, BrandId = 4, DailyPrice = 105000, ModelYear = 2021, ColorId = 4, Description = "Sedan" },
				new Car { Id = 5, BrandId = 3, DailyPrice = 135000, ModelYear = 2023, ColorId = 3, Description = "Hatchback" },
				new Car { Id = 6, BrandId = 6, DailyPrice = 130000, ModelYear = 2022, ColorId = 6, Description = "Sedan" },
				new Car { Id = 7, BrandId = 7, DailyPrice = 175000, ModelYear = 2023, ColorId = 5, Description = "Spor" });

			modelBuilder.Entity<Color>().HasData(
				new Color { Id = 1, Name = "Siyah" },
				new Color { Id = 2, Name = "Beyaz" },
				new Color { Id = 3, Name = "Lacivert" },
				new Color { Id = 4, Name = "Kahverengi" },
				new Color { Id = 5, Name = "Turuncu" },
				new Color { Id = 6, Name = "Kırmızı" });

			modelBuilder.Entity<Brand>().HasData(
				new Brand { Id = 1, Name = "Honda" },
				new Brand { Id = 2, Name = "Opel" },
				new Brand { Id = 3, Name = "Kia" },
				new Brand { Id = 4, Name = "Toyota" },
				new Brand { Id = 5, Name = "Renault" },
				new Brand { Id = 6, Name = "Hyundai" },
				new Brand { Id = 7, Name = "Ferrari" });

			




			base.OnModelCreating(modelBuilder);
		}
	}
}
