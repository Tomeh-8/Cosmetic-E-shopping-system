using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using cosmetic_hub__e_shopping_system_.ViewModels;
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

        public ActionResult ProductList(string productCategory)
        {
            string _productCategory = productCategory;
            IEnumerable<Product> products;
            string currentProductCategory;

            if (string.IsNullOrEmpty(_productCategory))
            {
                products = _productRepository.Products.OrderBy(p => p.Name);
                currentProductCategory = "All Products";
            }
            else
            {
                if (string.Equals("Skin Care Products", _productCategory))
                {
                    products = _productRepository.Products.Where(p => p.ProductCategory.ProductCategoryName.Equals("Skin Care Products")).OrderBy(p => p.Name);
                }
                                  
                else if (string.Equals("Perfumes", _productCategory))
                {
                    products = _productRepository.Products.Where(p => p.ProductCategory.ProductCategoryName.Equals("Perfumes")).OrderBy(p => p.Name);
                }

                else if (string.Equals("Hair Care Products", _productCategory))
                {
                    products = _productRepository.Products.Where(p => p.ProductCategory.ProductCategoryName.Equals("Hair Care Products")).OrderBy(p => p.Name);
                }

                else
                {
                    products = _productRepository.Products.Where(p => p.ProductCategory.ProductCategoryName.Equals("Face Care Products")).OrderBy(p => p.Name);
                }

                currentProductCategory = _productCategory;
            }

            ProductListViewModel List = new ProductListViewModel()
            {
                Products = products,
                currentProductCategory = currentProductCategory
            };

            return View(List);
        }

        [HttpGet]
        public ActionResult ProductDetails(int id)
        {
            var product = _productRepository.Products.FirstOrDefault(pp => pp.ProductId == id);
            if (product == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(product);
        }

        public ActionResult ProductSearch(string search)
        {
            IEnumerable<Product>products;
            string currentProductCategory = string.Empty;

            if (string.IsNullOrEmpty(search))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);

            } else
            {
                products = _productRepository.Products.Where(p => p.Name.ToLower().Contains(search.ToLower()));
            }

            ProductListViewModel List = new ProductListViewModel()
            {
                Products = products,
                currentProductCategory = "All Products"
            };


            return View(List);

        }

    }
}
