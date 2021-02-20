using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal ProductPrice { get; set; }

        public string ShortProductDetails { get; set; }

        public string LongProductDetails{ get; set; }

        public string Image { get; set; }

        public string ImageThumbnail { get; set; }

        public bool IsPreferredProduct { get; set; }

        public bool InStock { get; set; }

        public int ProductCategoryId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }




    }
}
