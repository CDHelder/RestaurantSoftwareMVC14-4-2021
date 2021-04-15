using Microsoft.EntityFrameworkCore;
using RestaurantSoftwareMVC14_4_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSoftwareMVC14_4_2021.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories (food and drinks)
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Food", Description = "All food related items in the menu" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Drinks", Description = "All drink related items in the menu" });

            //seed products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Sprite",
                Description = "Cold sprite served with ice cubes",
                CategoryId = 2,
                InStock = true,
                Price = 3.95M,
                IsSpecialtyOfTheWeek = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Spaghetti Carbonara",
                Description = "Spaghetti served with carbonara sauce and pieces of bacon",
                CategoryId = 1,
                InStock = true,
                Price = 19.95M,
                IsSpecialtyOfTheWeek = true
            });

        }
    }
}
