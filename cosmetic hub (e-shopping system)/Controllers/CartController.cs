using System;
using System.Collections.Generic;
using cosmetic_hub__e_shopping_system_.Models;
using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cosmetic_hub__e_shopping_system_.Controllers
{
    public class CartController : Controller
    {
        private static ShoppingCart _shoppingCart = new ShoppingCart();
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartItemsRepository _shoppingCartItemsRepository;

        public CartController(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository, IShoppingCartItemsRepository shoppingCartItemsRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
            _shoppingCartItemsRepository = shoppingCartItemsRepository;
        }



        public ActionResult ViewCart()
        {
            IEnumerable<ShoppingCartItems> items = _shoppingCartRepository.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            ShoppingCartViewModel Cart = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCartRepository.GetShoppingCartTotal()
            };

            return View(Cart);
        }

        public ActionResult AddToCart(int productId, ShoppingCart model )
        {
            var selectedProduct = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                _shoppingCartRepository.AddProductToCart(selectedProduct, 1);
            }
            return RedirectToAction( "ProductList", "Product");
        }

        public ActionResult RemoveFromCart(int productId)
        {
            var selectedProduct = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                _shoppingCartRepository.RemoveProductToCart(selectedProduct);
            }

            return RedirectToAction("ViewCart");
        }


        public ActionResult ClearCart()
        {
            _shoppingCartRepository.ClearShoppingCart();
             return RedirectToAction("ViewCart");
        }
    }
}
