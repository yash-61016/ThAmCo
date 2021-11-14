﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Catering.Models;

namespace ThAmCo.Catering.Migrations
{
    [DbContext(typeof(CateringContext))]
    [Migration("20211114011903_seedData2")]
    partial class seedData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThAmCo.Catering.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("FoodItemID");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            FoodItemID = 1,
                            Description = "Shepherd’s Pie",
                            UnitPrice = 3.5f
                        },
                        new
                        {
                            FoodItemID = 2,
                            Description = "Beef Wellington",
                            UnitPrice = 5f
                        },
                        new
                        {
                            FoodItemID = 3,
                            Description = "Naan",
                            UnitPrice = 3.75f
                        },
                        new
                        {
                            FoodItemID = 4,
                            Description = "Chicken Tikka Masala",
                            UnitPrice = 2.5f
                        },
                        new
                        {
                            FoodItemID = 5,
                            Description = "Pizza",
                            UnitPrice = 3.75f
                        },
                        new
                        {
                            FoodItemID = 6,
                            Description = "Ravioli",
                            UnitPrice = 5.5f
                        },
                        new
                        {
                            FoodItemID = 7,
                            Description = "Lasagna",
                            UnitPrice = 3.25f
                        },
                        new
                        {
                            FoodItemID = 8,
                            Description = "Fried Rice",
                            UnitPrice = 2.95f
                        },
                        new
                        {
                            FoodItemID = 9,
                            Description = "Spring Roles",
                            UnitPrice = 2.6f
                        },
                        new
                        {
                            FoodItemID = 10,
                            Description = "Rib Eye Steak",
                            UnitPrice = 4.9f
                        });
                });

            modelBuilder.Entity("ThAmCo.Catering.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MenuId = 1,
                            MenuName = "British Cuisine"
                        },
                        new
                        {
                            MenuId = 2,
                            MenuName = "Indian Cuisine"
                        },
                        new
                        {
                            MenuId = 3,
                            MenuName = "Italian Cuisine"
                        },
                        new
                        {
                            MenuId = 4,
                            MenuName = "Chinese Cuisine"
                        });
                });

            modelBuilder.Entity("ThAmCo.Catering.Models.MenuFoodItem", b =>
                {
                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.HasKey("MenuId", "FoodItemId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("MenuFoodItems");

                    b.HasData(
                        new
                        {
                            MenuId = 1,
                            FoodItemId = 1
                        },
                        new
                        {
                            MenuId = 1,
                            FoodItemId = 2
                        },
                        new
                        {
                            MenuId = 2,
                            FoodItemId = 3
                        },
                        new
                        {
                            MenuId = 2,
                            FoodItemId = 4
                        },
                        new
                        {
                            MenuId = 3,
                            FoodItemId = 5
                        },
                        new
                        {
                            MenuId = 3,
                            FoodItemId = 6
                        },
                        new
                        {
                            MenuId = 3,
                            FoodItemId = 7
                        },
                        new
                        {
                            MenuId = 3,
                            FoodItemId = 8
                        },
                        new
                        {
                            MenuId = 4,
                            FoodItemId = 9
                        },
                        new
                        {
                            MenuId = 1,
                            FoodItemId = 10
                        });
                });

            modelBuilder.Entity("ThAmCo.Catering.Models.MenuFoodItem", b =>
                {
                    b.HasOne("ThAmCo.Catering.Models.FoodItem", "FoodItem")
                        .WithMany()
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThAmCo.Catering.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
