using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Mock
{
    public class MockProductCategoryRepository: IProductCategoryRepository
    {
        public IEnumerable<ProductCategory> productCategories
        {
            get
            {
                return new List<ProductCategory>
                {
                    new ProductCategory{ ProductCategoryName = "Skin Care Products", ProductCategoryDetails = "All Skin Care Products"},
                    new ProductCategory{ ProductCategoryName = "Perfumes", ProductCategoryDetails = "All Perfumes"},
                    new ProductCategory{ ProductCategoryName = "Hair Care Products", ProductCategoryDetails = "All Hair Care Products"},
                    new ProductCategory{ ProductCategoryName = "Face Care Products", ProductCategoryDetails = "All Face Care Products"}
                };
            }
        }

    }
}
