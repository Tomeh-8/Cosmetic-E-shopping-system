using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class ShoppingCartItems
    {
        public int ShoppingCartItemsId { get; set; }

        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
