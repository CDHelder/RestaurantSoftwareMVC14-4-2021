using RestaurantSoftwareMVC14_4_2021.Data.Repositories.Interface_Repositories;
using RestaurantSoftwareMVC14_4_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSoftwareMVC14_4_2021.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RestaurantDbContext restaurantDbContext;

        public CategoryRepository(RestaurantDbContext restaurantDbContext)
        {
            this.restaurantDbContext = restaurantDbContext;
        }

        public IEnumerable<Category> AllCategories => restaurantDbContext.Categories;
    }
}
