﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestoRite_DataAccessLayer.Data;

#nullable disable

namespace RestoRite_DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestoRite_Entities.DataModels.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "New York",
                            CountryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Los Angeles",
                            CountryId = 1
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Chicago",
                            CountryId = 1
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Houston",
                            CountryId = 1
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Toronto",
                            CountryId = 2
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Vancouver",
                            CountryId = 2
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Montreal",
                            CountryId = 2
                        },
                        new
                        {
                            Id = 8,
                            CityName = "London",
                            CountryId = 3
                        },
                        new
                        {
                            Id = 9,
                            CityName = "Manchester",
                            CountryId = 3
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Birmingham",
                            CountryId = 3
                        },
                        new
                        {
                            Id = 11,
                            CityName = "Sydney",
                            CountryId = 4
                        },
                        new
                        {
                            Id = 12,
                            CityName = "Melbourne",
                            CountryId = 4
                        },
                        new
                        {
                            Id = 13,
                            CityName = "Brisbane",
                            CountryId = 4
                        },
                        new
                        {
                            Id = 14,
                            CityName = "Berlin",
                            CountryId = 5
                        },
                        new
                        {
                            Id = 15,
                            CityName = "Munich",
                            CountryId = 5
                        },
                        new
                        {
                            Id = 16,
                            CityName = "Frankfurt",
                            CountryId = 5
                        },
                        new
                        {
                            Id = 17,
                            CityName = "Paris",
                            CountryId = 6
                        },
                        new
                        {
                            Id = 18,
                            CityName = "Lyon",
                            CountryId = 6
                        },
                        new
                        {
                            Id = 19,
                            CityName = "Marseille",
                            CountryId = 6
                        },
                        new
                        {
                            Id = 20,
                            CityName = "Rome",
                            CountryId = 7
                        },
                        new
                        {
                            Id = 21,
                            CityName = "Milan",
                            CountryId = 7
                        },
                        new
                        {
                            Id = 22,
                            CityName = "Naples",
                            CountryId = 7
                        },
                        new
                        {
                            Id = 23,
                            CityName = "Madrid",
                            CountryId = 8
                        },
                        new
                        {
                            Id = 24,
                            CityName = "Barcelona",
                            CountryId = 8
                        },
                        new
                        {
                            Id = 25,
                            CityName = "Valencia",
                            CountryId = 8
                        },
                        new
                        {
                            Id = 26,
                            CityName = "Tokyo",
                            CountryId = 9
                        },
                        new
                        {
                            Id = 27,
                            CityName = "Osaka",
                            CountryId = 9
                        },
                        new
                        {
                            Id = 28,
                            CityName = "Kyoto",
                            CountryId = 9
                        },
                        new
                        {
                            Id = 29,
                            CityName = "Beijing",
                            CountryId = 10
                        },
                        new
                        {
                            Id = 30,
                            CityName = "Shanghai",
                            CountryId = 10
                        },
                        new
                        {
                            Id = 31,
                            CityName = "Shenzhen",
                            CountryId = 10
                        },
                        new
                        {
                            Id = 32,
                            CityName = "Mumbai",
                            CountryId = 11
                        },
                        new
                        {
                            Id = 33,
                            CityName = "Delhi",
                            CountryId = 11
                        },
                        new
                        {
                            Id = 34,
                            CityName = "Bangalore",
                            CountryId = 11
                        },
                        new
                        {
                            Id = 35,
                            CityName = "São Paulo",
                            CountryId = 12
                        },
                        new
                        {
                            Id = 36,
                            CityName = "Rio de Janeiro",
                            CountryId = 12
                        },
                        new
                        {
                            Id = 37,
                            CityName = "Brasília",
                            CountryId = 12
                        },
                        new
                        {
                            Id = 38,
                            CityName = "Moscow",
                            CountryId = 13
                        },
                        new
                        {
                            Id = 39,
                            CityName = "Saint Petersburg",
                            CountryId = 13
                        },
                        new
                        {
                            Id = 40,
                            CityName = "Novosibirsk",
                            CountryId = 13
                        },
                        new
                        {
                            Id = 41,
                            CityName = "Seoul",
                            CountryId = 14
                        },
                        new
                        {
                            Id = 42,
                            CityName = "Busan",
                            CountryId = 14
                        },
                        new
                        {
                            Id = 43,
                            CityName = "Incheon",
                            CountryId = 14
                        },
                        new
                        {
                            Id = 44,
                            CityName = "Johannesburg",
                            CountryId = 15
                        },
                        new
                        {
                            Id = 45,
                            CityName = "Cape Town",
                            CountryId = 15
                        },
                        new
                        {
                            Id = 46,
                            CityName = "Durban",
                            CountryId = 15
                        });
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "United States"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "United Kingdom"
                        },
                        new
                        {
                            Id = 4,
                            CountryName = "Australia"
                        },
                        new
                        {
                            Id = 5,
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 6,
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 7,
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 8,
                            CountryName = "Spain"
                        },
                        new
                        {
                            Id = 9,
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 10,
                            CountryName = "China"
                        },
                        new
                        {
                            Id = 11,
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 12,
                            CountryName = "Brazil"
                        },
                        new
                        {
                            Id = 13,
                            CountryName = "Russia"
                        },
                        new
                        {
                            Id = 14,
                            CountryName = "South Korea"
                        },
                        new
                        {
                            Id = 15,
                            CountryName = "South Africa"
                        });
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantBranchId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("RestaurantBranchId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("InvoiceNumber")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RestaurantBranchId")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantBranchId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DishCategory")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("DishImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantBranchId")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("RestaurantBranchId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantBranchId")
                        .HasColumnType("int");

                    b.Property<byte>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("tinyint");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MenuId");

                    b.HasIndex("RestaurantBranchId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Descrption")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Logo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.RestaurantBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("OwnerId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("RestaurantBranches");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OTP")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.City", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.Country", "Countries")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Ingredient", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.RestaurantBranch", "RestaurantBranches")
                        .WithMany()
                        .HasForeignKey("RestaurantBranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");

                    b.Navigation("RestaurantBranches");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Invoice", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "Users")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.RestaurantBranch", "RestaurantBranches")
                        .WithMany()
                        .HasForeignKey("RestaurantBranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");

                    b.Navigation("RestaurantBranches");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Menu", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.RestaurantBranch", "RestaurantBranches")
                        .WithMany()
                        .HasForeignKey("RestaurantBranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");

                    b.Navigation("RestaurantBranches");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Order", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "User")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.RestaurantBranch", "RestaurantBranch")
                        .WithMany()
                        .HasForeignKey("RestaurantBranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");

                    b.Navigation("Menu");

                    b.Navigation("RestaurantBranch");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.Restaurant", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.RestaurantBranch", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.City", "Cities")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.Country", "Countries")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "Users")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.Restaurant", "Restaurants")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cities");

                    b.Navigation("Countries");

                    b.Navigation("CreatedByUser");

                    b.Navigation("Restaurants");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RestoRite_Entities.DataModels.User", b =>
                {
                    b.HasOne("RestoRite_Entities.DataModels.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestoRite_Entities.DataModels.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });
#pragma warning restore 612, 618
        }
    }
}
