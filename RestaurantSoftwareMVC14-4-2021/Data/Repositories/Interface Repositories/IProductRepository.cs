using RestaurantSoftwareMVC14_4_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSoftwareMVC14_4_2021.Data.Repositories.Interface_Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> Specialtyoftheweek { get; }
        Product GetProductById(int productId);
        Product Create(Product product);
    }
}
