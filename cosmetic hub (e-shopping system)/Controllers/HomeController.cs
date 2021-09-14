using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cosmetic_hub__e_shopping_system_.Models;
using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.ViewModels;

namespace cosmetic_hub__e_shopping_system_.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            var homeModel = new HomeViewModel()
            {
                PreferredProducts = _productRepository.PreferredProducts
            };
            return View(homeModel);
        }
    }
        
}
