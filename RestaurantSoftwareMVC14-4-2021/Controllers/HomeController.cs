using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantSoftwareMVC14_4_2021.Data.Repositories.Interface_Repositories;
using RestaurantSoftwareMVC14_4_2021.Models;
using RestaurantSoftwareMVC14_4_2021.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSoftwareMVC14_4_2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SpecialtyOfTheWeek = _productRepository.Specialtyoftheweek
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
