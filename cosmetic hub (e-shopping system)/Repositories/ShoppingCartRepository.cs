using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly AppDbContext _appDbContext;


        public ShoppingCartRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string shoppingCartId { get; set; } 

        public IEnumerable<ShoppingCartItems> GetShoppingCartItems()
        {
           // var cartItems = _appDbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == shoppingCartId).Include(p => p.Product).ToList();
            var cartItems = _appDbContext.ShoppingCartItems.Include(p => p.Product).ToList();

            return cartItems;
        }

      //  public ShoppingCartItems GetShoppingCartItems(int shoppingCartId)
      //  {
       //     var cartItem = _appDbContext.ShoppingCartItems.Find(shoppingCartId);
        //    return cartItem;
       // }

      //  public ShoppingCart GetCart(IServiceProvider services)
       // {
       //    ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;

       //   var context = services.GetService<AppDbContext>();
            
        //    string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

        //   session.SetString("CartId", "cartId");

       //     return new ShoppingCart { ShoppingCartId = cartId };
       // }


        public void AddProductToCart(Product product, int Amount)
        {
            
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Product.ProductId == product.ProductId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItems
                {
                    Product = product,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public void RemoveProductToCart(Product product)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Product.ProductId == product.ProductId);
           

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                  shoppingCartItem.Amount--;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

      
        }

        public void ClearShoppingCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems;
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }


        public string GetShoppingCartTotal()
        {
            return _appDbContext.ShoppingCartItems.Select(sc => sc.Product.ProductPrice * sc.Amount).Sum().ToString("0.00");   
        }

      
    }
}
 