using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        public string ProductCategoryName { get; set; }

        public string ProductCategoryDetails { get; set; }

        public List<Product> Products { get; set; }

    }
}
