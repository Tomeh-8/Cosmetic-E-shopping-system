using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }

        public IEnumerable<ShoppingCartItems> ShoppingCartItems { get; set; }
    }
}
