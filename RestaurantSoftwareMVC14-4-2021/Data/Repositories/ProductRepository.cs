using Microsoft.EntityFrameworkCore;
using RestaurantSoftwareMVC14_4_2021.Data.Repositories.Interface_Repositories;
using RestaurantSoftwareMVC14_4_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSoftwareMVC14_4_2021.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly RestaurantDbContext restaurantDbContext;

        public ProductRepository(RestaurantDbContext restaurantDbContext)
        {
            this.restaurantDbContext = restaurantDbContext;
        }
        public IEnumerable<Product> AllProducts
        {
            get
            {
                return restaurantDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> Specialtyoftheweek
        {
            get
            {
                return restaurantDbContext.Products.Include(c => c.Category).Where(p => p.IsSpecialtyOfTheWeek == true);
            }
        }

        public Product Create(Product product)
        {
            restaurantDbContext.Products.Add(product);
            restaurantDbContext.SaveChanges();
            return product;
        }

        public Product GetProductById(int productId)
        {
            return restaurantDbContext.Products.FirstOrDefault(abc => abc.ProductId == productId);
        }
    }
}
