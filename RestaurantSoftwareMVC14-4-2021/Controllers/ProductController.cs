using Microsoft.AspNetCore.Mvc;
using RestaurantSoftwareMVC14_4_2021.Data.Repositories;
using RestaurantSoftwareMVC14_4_2021.Data.Repositories.Interface_Repositories;
using RestaurantSoftwareMVC14_4_2021.Models;
using RestaurantSoftwareMVC14_4_2021.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSoftwareMVC14_4_2021.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            ProductsListViewModel productsListViewModel = new ProductsListViewModel();
            productsListViewModel.Products = productRepository.AllProducts;
            productsListViewModel.Categories = categoryRepository.AllCategories;

            return View(productsListViewModel);
        }

        public IActionResult Details(int id)
        {
            var product = productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }

        public IActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                var newProduct = productRepository.Create(product);
                return RedirectToAction("Details/" + newProduct.ProductId);
            }
            else
                return View(product);
        }

    }
}
