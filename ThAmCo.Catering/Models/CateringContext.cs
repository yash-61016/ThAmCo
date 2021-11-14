using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class CateringContext : DbContext
    {
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<MenuFoodItem> MenuFoodItems { get; set;}
        public DbSet<Menu> Menus { get; set; }
        public DbSet<FoodBooking> FoodBookings { get; set; }
        
        
    public CateringContext(DbContextOptions<CateringContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MenuFoodItem>()
             .HasKey(a => new { a.MenuId, a.FoodItemId });


            builder.Entity<MenuFoodItem>().
                HasOne(a => a.FoodItem)
                .WithMany()
                .HasForeignKey(b => b.FoodItemId);

            builder.Entity<MenuFoodItem>().
                HasOne(a => a.Menu)
                .WithMany()
                .HasForeignKey(b => b.MenuId);

            builder.Entity<FoodBooking>().
                HasOne(a => a.menu)
                .WithMany()
                .HasForeignKey(b => b.MenuId);


            builder.Entity<FoodItem>().HasData(
                new FoodItem { 
                    FoodItemID = 1,
                    Description = "Shepherd’s Pie",
                    UnitPrice = 3.50f   
                },
                new FoodItem
                {
                    FoodItemID = 2,
                    Description = "Beef Wellington",
                    UnitPrice = 5.00f
                },
                new FoodItem
                {
                    FoodItemID = 3,
                    Description = "Naan",
                    UnitPrice = 3.75f
                },
                new FoodItem
                {
                    Description = "Chicken Tikka Masala",
                    FoodItemID = 4,
                    UnitPrice = 2.50f
                }, 
                new FoodItem
                {
                    FoodItemID = 5,
                    Description = "Pizza",
                    UnitPrice = 3.75f
                }, 
                new FoodItem
                {
                    FoodItemID = 6,
                    Description = "Ravioli",
                    UnitPrice = 5.50f
                }, 
                new FoodItem
                {
                    FoodItemID = 7,
                    Description = "Lasagna",
                    UnitPrice = 3.25f
                }, 
                new FoodItem
                {
                    FoodItemID = 8,
                    Description = "Fried Rice",
                    UnitPrice = 2.95f
                }, 
                new FoodItem
                {
                    FoodItemID = 9,
                    Description = "Spring Roles",
                    UnitPrice = 2.60f
                },
                new FoodItem
                {
                    Description = "Rib Eye Steak",
                    FoodItemID = 10,
                    UnitPrice = 4.90f
                }
                );

            builder.Entity<Menu>().HasData(
                new Menu { MenuId = 1, MenuName = "British Cuisine"},
                new Menu { MenuId = 2, MenuName = "Indian Cuisine"},
                new Menu { MenuId = 3, MenuName = "Italian Cuisine"},
                new Menu { MenuId = 4, MenuName = "Chinese Cuisine"}
                );
            builder.Entity<MenuFoodItem>().HasData(
                new MenuFoodItem { MenuId = 1, FoodItemId = 1},
                new MenuFoodItem { MenuId = 1, FoodItemId = 2},
                new MenuFoodItem { MenuId = 2, FoodItemId = 3 },
                new MenuFoodItem { MenuId = 2, FoodItemId = 4 },
                new MenuFoodItem { MenuId = 3, FoodItemId = 5 },
                new MenuFoodItem { MenuId = 3, FoodItemId = 6 },
                new MenuFoodItem { MenuId = 3, FoodItemId = 7 },
                new MenuFoodItem { MenuId = 3, FoodItemId = 8 },
                new MenuFoodItem { MenuId = 4, FoodItemId = 9 },
                new MenuFoodItem { MenuId = 1, FoodItemId = 10 }
                );
            builder.Entity<FoodBooking>().HasData(
                new FoodBooking { FoodBookingId = 1, ClientReferenceId = 123, MenuId = 1, NumberOfGuests = 10},
                new FoodBooking { FoodBookingId = 2, ClientReferenceId = 321, MenuId = 2, NumberOfGuests = 23 },
                new FoodBooking { FoodBookingId = 3, ClientReferenceId = 234, MenuId = 3, NumberOfGuests = 20 },
                new FoodBooking { FoodBookingId = 4, ClientReferenceId = 345, MenuId = 4, NumberOfGuests = 35 }
                );
        }
        }
    }
