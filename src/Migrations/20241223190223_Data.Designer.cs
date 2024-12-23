﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurants.DataAccessor;

#nullable disable

namespace Restaurants.Migrations
{
    [DbContext(typeof(ResturantDbContext))]
    [Migration("20241223190223_Data")]
    partial class Data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restaurants.Models.Domains.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Restaurants.Models.Domains.Resturant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasDelivery")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resturants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Italian",
                            Description = "A cozy place for authentic Italian cuisine.",
                            Email = "contact@italianbistro.com",
                            HasDelivery = true,
                            Name = "Italian Bistro",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Japanese",
                            Description = "Fresh and delicious sushi.",
                            Email = "info@sushiworld.com",
                            HasDelivery = false,
                            Name = "Sushi World",
                            PhoneNumber = "987-654-3210"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Mexican",
                            Description = "Best tacos in town.",
                            Email = "order@tacofiesta.com",
                            HasDelivery = true,
                            Name = "Taco Fiesta",
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            Id = 4,
                            Category = "American",
                            Description = "Juicy burgers and crispy fries.",
                            Email = "support@burgerhaven.com",
                            HasDelivery = false,
                            Name = "Burger Haven",
                            PhoneNumber = "444-555-6666"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Indian",
                            Description = "Authentic Indian curries.",
                            Email = "contact@curryhouse.com",
                            HasDelivery = true,
                            Name = "Curry House",
                            PhoneNumber = "333-222-1111"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}