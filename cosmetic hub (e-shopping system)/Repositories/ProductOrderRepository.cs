using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Repositories
{
    public class ProductOrderRepository : IProductOrderRepository
    {
        private readonly AppDbContext _appDbContext;
       // private readonly ShoppingCartItems _shoppingCartItems;

        public ProductOrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateProductOrder(ProductOrder order)
        {
            order.ProductOrderPlaced = DateTime.Now;
            _appDbContext.ProductOrders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _appDbContext.ShoppingCartItems;

            foreach(var shoppingCartItem in shoppingCartItems)
            {
                var productOrderDetail = new ProductOrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    ProductOrderId = order.ProductOrderId,
                    ProductPrice = shoppingCartItem.Product.ProductPrice
                };

                _appDbContext.ProductOrderDetails.Add(productOrderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
