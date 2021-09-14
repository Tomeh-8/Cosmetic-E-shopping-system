using cosmetic_hub__e_shopping_system_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }

      
        public string ShoppingCartTotal { get; set; }
    }
}
