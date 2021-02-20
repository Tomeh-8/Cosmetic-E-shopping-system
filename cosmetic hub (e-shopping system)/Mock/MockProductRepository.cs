using cosmetic_hub__e_shopping_system_.Interfaces;
using cosmetic_hub__e_shopping_system_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Mock
{
    public class MockProductRepository : IProductRepository
    {
        private readonly IProductCategoryRepository _productCategoryRepository = new MockProductCategoryRepository();
        public IEnumerable<Product> Products 
        { 
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name = "212 Men",
                        ProductPrice = 7000,
                        ShortProductDetails = "",
                        LongProductDetails = "",
                        Image = "",
                        ImageThumbnail = "",
                        InStock = true,
                        IsPreferredProduct = true,
                        ProductCategory = _productCategoryRepository.productCategories.First(),
                        },
                    new Product {
                        Name = "Soulmate",
                        ProductPrice = 12950,
                        ShortProductDetails = "",
                        LongProductDetails = "",
                        Image = "",
                        ImageThumbnail = "",
                        InStock = true,
                        IsPreferredProduct = false,
                        ProductCategory =  _productCategoryRepository.productCategories.First(),
                    },
                    new Product {
                        Name = "lemon fresh",
                        ProductPrice = 6000, 
                        ShortProductDetails = "",
                        LongProductDetails = "",
                        Image = "",
                        ImageThumbnail = "",
                        InStock = true,
                        IsPreferredProduct = false,
                        ProductCategory =  _productCategoryRepository.productCategories.First()
                    },
                    new Product
                    {
                        Name = "Jergens",
                        ProductPrice = 5000,
                        ShortProductDetails = "",
                        LongProductDetails = "",
                        Image = "",
                        ImageThumbnail = "",
                        InStock = true,
                        IsPreferredProduct = false,
                        ProductCategory = _productCategoryRepository.productCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Product> PreferredProducts { get; }
        
        public Product GetProductById(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}
