using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly AppDbContext _AppDbcontext;

        public ProductCategoryRepository(AppDbContext AppDbContext)
        {
            _AppDbcontext = AppDbContext;
        }
        public IEnumerable<ProductCategory> productCategories => _AppDbcontext.ProductCategories;
    }
}
