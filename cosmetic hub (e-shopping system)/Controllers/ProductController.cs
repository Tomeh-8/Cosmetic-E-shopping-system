using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cosmetic_hub__e_shopping_system_.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmetic_hub__e_shopping_system_.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductController(IProductRepository productRepository, IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _productCategoryRepository = productCategoryRepository;
        }

        public ActionResult ProductList()
        {
            ViewBag.Name = "Tomeh";
            var products = _productRepository.Products;
            return View(products);
        }
       
    }
}
