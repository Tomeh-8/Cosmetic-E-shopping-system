using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using Microsoft.AspNetCore.Mvc;

namespace cosmetic_hub__e_shopping_system_.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductOrderRepository _productOrderRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public OrderController(IProductOrderRepository productOrderRepository, IShoppingCartRepository shoppingCartRepository)
        {
            _productOrderRepository = productOrderRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(ProductOrder order)
        {
            var cartItems = _shoppingCartRepository.GetShoppingCartItems();

            if(cartItems.Count() == 0)
            {
                ModelState.AddModelError("", "your cart is empty");
            }

            if (ModelState.IsValid)
            {
                _productOrderRepository.CreateProductOrder(order);
                _shoppingCartRepository.ClearShoppingCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View();
        }

        public IActionResult CheckoutComplete()
        {
          
            return View();
        }
    }
}
