﻿// <auto-generated />
using System;
using DataAccess.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231019122904_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concreate.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Opel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kia"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Renault"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Ferrari"
                        });
                });

            modelBuilder.Entity("Entities.Concreate.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CarImageId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<double>("DailyPrice")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int");

                    b.Property<int?>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CarImageId");

                    b.HasIndex("ColorId");

                    b.HasIndex("RentalId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 2,
                            ColorId = 1,
                            DailyPrice = 100000.0,
                            Description = "Hatchback",
                            ModelYear = 2023
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 5,
                            ColorId = 2,
                            DailyPrice = 125000.0,
                            Description = "Hatchback",
                            ModelYear = 2023
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            ColorId = 5,
                            DailyPrice = 115000.0,
                            Description = "Sedan",
                            ModelYear = 2022
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 4,
                            ColorId = 4,
                            DailyPrice = 105000.0,
                            Description = "Sedan",
                            ModelYear = 2021
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 3,
                            ColorId = 3,
                            DailyPrice = 135000.0,
                            Description = "Hatchback",
                            ModelYear = 2023
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 6,
                            ColorId = 6,
                            DailyPrice = 130000.0,
                            Description = "Sedan",
                            ModelYear = 2022
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 7,
                            ColorId = 5,
                            DailyPrice = 175000.0,
                            Description = "Spor",
                            ModelYear = 2023
                        });
                });

            modelBuilder.Entity("Entities.Concreate.CarImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CarImages");
                });

            modelBuilder.Entity("Entities.Concreate.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Siyah"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Beyaz"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lacivert"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kahverengi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Turuncu"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Kırmızı"
                        });
                });

            modelBuilder.Entity("Entities.Concreate.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Agartha"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Tübitak"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Aselsan"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Erdemir"
                        },
                        new
                        {
                            Id = 5,
                            CompanyName = "Kardemir"
                        });
                });

            modelBuilder.Entity("Entities.Concreate.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CustormerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustormerId");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            CustormerId = 1,
                            RentDate = new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4362),
                            ReturnDate = new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4371)
                        },
                        new
                        {
                            Id = 2,
                            CarId = 4,
                            CustormerId = 2,
                            RentDate = new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4374),
                            ReturnDate = new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4375)
                        },
                        new
                        {
                            Id = 3,
                            CarId = 6,
                            CustormerId = 5,
                            RentDate = new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4376),
                            ReturnDate = new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4376)
                        });
                });

            modelBuilder.Entity("Entities.Concreate.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Email = "karayelyahya@gmail.com",
                            FirstName = "Yahya",
                            LastName = "Karayel",
                            Password = "Password12*"
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Email = "arımete@gmail.com",
                            FirstName = "Mete",
                            LastName = "Arı",
                            Password = "Password12*"
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 4,
                            Email = "sadimehmet@gmail.com",
                            FirstName = "Mehmet",
                            LastName = "Sadi",
                            Password = "Password12*"
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 5,
                            Email = "tuncece@gmail.com",
                            FirstName = "Ece",
                            LastName = "Tunç",
                            Password = "Password12*"
                        });
                });

            modelBuilder.Entity("Entities.Concreate.Car", b =>
                {
                    b.HasOne("Entities.Concreate.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concreate.CarImage", "CarImage")
                        .WithMany()
                        .HasForeignKey("CarImageId");

                    b.HasOne("Entities.Concreate.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concreate.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("RentalId");

                    b.Navigation("Brand");

                    b.Navigation("CarImage");

                    b.Navigation("Color");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Entities.Concreate.Rental", b =>
                {
                    b.HasOne("Entities.Concreate.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustormerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.Concreate.User", b =>
                {
                    b.HasOne("Entities.Concreate.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
