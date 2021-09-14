using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _AppDbcontext;

        public ProductRepository(AppDbContext AppDbContext)
        {
            _AppDbcontext = AppDbContext;
        }
        public IEnumerable<Product> Products => _AppDbcontext.Products.Include(pc => pc.ProductCategory);

        public IEnumerable<Product> PreferredProducts => _AppDbcontext.Products.Where(pp => pp.IsPreferredProduct).Include(pc => pc.ProductCategory);

        public Product GetProductById(int productId)
        {
            return _AppDbcontext.Products.Find(productId);
        }


    }
}
