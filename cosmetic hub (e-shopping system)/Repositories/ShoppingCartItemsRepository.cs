using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Repositories
{
    public class ShoppingCartItemsRepository: IShoppingCartItemsRepository
    {
        private readonly AppDbContext _appDbContext;

        public ShoppingCartItemsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void AddShoppingItems(ShoppingCartItems shoppingCartItem)
        {
            _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<ShoppingCartItems> GetAllShoppingItems()
        {
            return _appDbContext.ShoppingCartItems;
        }

        public void SaveShoppingItems()
        {
            _appDbContext.SaveChanges();
        }
    }
}
