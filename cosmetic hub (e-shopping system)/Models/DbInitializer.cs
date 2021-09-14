using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
                if (!context.ProductCategories.Any())
                {
                    context.ProductCategories.AddRange(ProductCategories.Select(pc => pc.Value));
                }

                if (!context.Products.Any())
                {
                    context.Products.AddRange
                        (
                          new Product
                          {
                              Name = "212 Men",
                              ProductPrice = 7000,
                              ShortProductDetails = "Gives you the best fragrance all day",
                              LongProductDetails = "212 Men has selected the best Argan Organic Oil strictly produced in Morocco. Thanks to its exceptional moisturizing, nourishing, antioxidant, elasticizing and cicatrizing properties, it is the best oil for face, body and hair rejuvenation and revitalization. Efficient against wrinkles, free radicals, to soothe the small skin irritations and give well-being during the massage. Perfect also for the hair ends and to strengthen nails",
                              Image = "/images/212men.jpg",
                              ImageThumbnail = "/images/212men.jpg",
                              InStock = true,
                              IsPreferredProduct = true,
                              ProductCategory = ProductCategories["Perfumes"],

                          },
                        new Product
                        {
                            Name = "Soulmate",
                            ProductPrice = 12950,
                            ShortProductDetails = "Gives your hair a nourishing spark",
                            LongProductDetails = "Soulmate has selected the best Argan Organic Oil strictly produced in Morocco.Thanks to its exceptional moisturizing,nourishing,antioxidant elasticizing and cicatrizing properties,it is the best oil for face, body and hair rejuvenation and revitalization.Efficient against wrinkles, free radicals, to soothe the small skin irritations and give well - being during the massage.Perfect also for the hair ends and to strengthen nails",
                            Image = "/images/soulmate.jpg",
                            ImageThumbnail = "/images/soulmate.jpg",
                            InStock = true,
                            IsPreferredProduct = false,
                            ProductCategory = ProductCategories["Hair Care Products"],


                        },
                        new Product
                        {
                            Name = "lemon fresh facials",
                            ProductPrice = 6000,
                            ShortProductDetails = "For a radiant look",
                            LongProductDetails = "",
                            Image = "/images/lemonFresh.jpg",
                            ImageThumbnail = "/images/lemonFresh.jpg",
                            InStock = true,
                            IsPreferredProduct = false,
                            ProductCategory = ProductCategories["Face Care Products"],

                        },
                        new Product
                        {
                            Name = "Jergens",
                            ProductPrice = 5000,
                            ShortProductDetails = "For all beautiful skin types",
                            LongProductDetails = "",
                            Image = "/images/jergens.jpg",
                            ImageThumbnail = "/images/jergens.jpg",
                            InStock = true,
                            IsPreferredProduct = false,
                            ProductCategory = ProductCategories["Skin Care Products"],
                        },
                        new Product
                        {
                            Name = "Cerave",
                            ProductPrice = 4000,
                            ShortProductDetails = "Cleanses and restores dead skin",
                            LongProductDetails = "",
                            Image = "/images/cerave.jpg",
                            ImageThumbnail = "/images/cerave.jpg",
                            InStock = true,
                            IsPreferredProduct = true,
                            ProductCategory = ProductCategories["Face Care Products"],
                        },
                        new Product
                        {
                            Name = "Chanel",
                            ProductPrice = 11000,
                            ShortProductDetails = "Executive scent you can trust",
                            LongProductDetails = "",
                            Image = "/images/chanel.jpg",
                            ImageThumbnail = "/images/chanel.jpg",
                            InStock = true,
                            IsPreferredProduct = false,
                            ProductCategory = ProductCategories["Perfumes"],
                        },
                        new Product
                        {
                            Name = "Damatol",
                            ProductPrice = 8000,
                            ShortProductDetails = "For scalp and hair treatment",
                            LongProductDetails = "",
                            Image = "/images/damatol.jpg",
                            ImageThumbnail = "/images/damatol.jpg",
                            InStock = true,
                            IsPreferredProduct = false,
                            ProductCategory = ProductCategories["Hair Care Products"],
                        },
                        new Product
                        {
                            Name = "Mega Growth",
                            ProductPrice = 8000,
                            ShortProductDetails = "Perfect anti-breakage straighter",
                            LongProductDetails = "",
                            Image = "/images/megaGrowth.jpg",
                            ImageThumbnail = "/images/megaGrowth.jpg",
                            InStock = true,
                            IsPreferredProduct = true,
                            ProductCategory = ProductCategories["Hair Care Products"],
                        },
                        new Product
                        {
                            Name = "Vaseline",
                            ProductPrice = 3500,
                            ShortProductDetails = "Total moisturizing cream",
                            LongProductDetails = "",
                            Image = "/images/vaseline.jpg",
                            ImageThumbnail = "/images/vaseline.jpg",
                            InStock = true,
                            IsPreferredProduct = false,
                            ProductCategory = ProductCategories["Skin Care Products"],
                        },
                        new Product
                        {
                            Name = "Sauvage",
                            ProductPrice = 9000,
                            ShortProductDetails = "Scent for real men",
                            LongProductDetails = "",
                            Image = "/images/sauvage.jpg",
                            ImageThumbnail = "/images/sauvage.jpg",
                            InStock = true,
                            IsPreferredProduct = false,
                            ProductCategory = ProductCategories["Perfumes"],
                        },
                         new Product
                         {
                             Name = "Morgan",
                             ProductPrice = 4000,
                             ShortProductDetails = "Gradually darkens grey hair",
                             LongProductDetails = "",
                             Image = "/images/morgan.jpg",
                             ImageThumbnail = "/images/morgan.jpg",
                             InStock = true,
                             IsPreferredProduct = false,
                             ProductCategory = ProductCategories["Hair Care Products"],
                         },
                         new Product
                         {
                             Name = "Nivea Facials",
                             ProductPrice = 7000,
                             ShortProductDetails = "Milk delight face wash",
                             LongProductDetails = "",
                             Image = "/images/niveaFacial.jpg",
                             ImageThumbnail = "/images/niveaFacial.jpg",
                             InStock = true,
                             IsPreferredProduct = true,
                             ProductCategory = ProductCategories["Face Care Products"],
                         },
                          new Product
                          {
                              Name = "Eucerin",
                              ProductPrice = 8500,
                              ShortProductDetails = "Advanced repair lotion",
                              LongProductDetails = "",
                              Image = "/images/eucerin.png",
                              ImageThumbnail = "/images/eucerin.png",
                              InStock = true,
                              IsPreferredProduct = false,
                              ProductCategory = ProductCategories["Skin Care Products"],
                          },
                           new Product
                           {
                               Name = "Jk Perfume",
                               ProductPrice = 26000,
                               ShortProductDetails = "Celebrity status",
                               LongProductDetails = "",
                               Image = "/images/perfume.png",
                               ImageThumbnail = "/images/perfume.png",
                               InStock = true,
                               IsPreferredProduct = false,
                               ProductCategory = ProductCategories["Perfumes"],
                           },
                         new Product
                         {
                             Name = "Andrea",
                             ProductPrice = 12000,
                             ShortProductDetails = "Rich daily mositurizer and repair",
                             LongProductDetails = "",
                             Image = "/images/andrea.jpg",
                             ImageThumbnail = "/images/andrea.jpg",
                             InStock = true,
                             IsPreferredProduct = true,
                             ProductCategory = ProductCategories["Hair Care Products"],
                         },
                         new Product
                         {
                             Name = "Olay Facials",
                             ProductPrice = 7000,
                             ShortProductDetails = "Micro-sculpting cream",
                             LongProductDetails = "",
                             Image = "/images/olay.jpg",
                             ImageThumbnail = "/images/olay.jpg",
                             InStock = true,
                             IsPreferredProduct = true,
                             ProductCategory = ProductCategories["Face Care Products"],
                         },
                          
                          new Product
                          {
                              Name = "Oud Perfume",
                              ProductPrice = 15000,
                              ShortProductDetails = "Cologne extraordinaire",
                              LongProductDetails = "",
                              Image = "/images/oud.jpg",
                              ImageThumbnail = "/images/oud.jpg",
                              InStock = true,
                              IsPreferredProduct = false,
                              ProductCategory = ProductCategories["Perfumes"],
                          },
                         new Product
                         {
                             Name = "Olive oil",
                             ProductPrice = 4500,
                             ShortProductDetails = "Infused with castor oil for strengthening",
                             LongProductDetails = "",
                             Image = "/images/ors.jpg",
                             ImageThumbnail = "/images/ors.jpg",
                             InStock = true,
                             IsPreferredProduct = false,
                             ProductCategory = ProductCategories["Hair Care Products"],
                         },
                         new Product
                         {
                             Name = "Toleraine Facials",
                             ProductPrice = 7999,
                             ShortProductDetails = "Double repair face moisturizer",
                             LongProductDetails = "",
                             Image = "/images/toleraine.jpg",
                             ImageThumbnail = "/images/toleraine.jpg",
                             InStock = true,
                             IsPreferredProduct = true,
                             ProductCategory = ProductCategories["Face Care Products"],
                         },
                          new Product
                          {
                              Name = "Oud",
                              ProductPrice = 21000,
                              ShortProductDetails = "A scent you can trust",
                              LongProductDetails = "",
                              Image = "/images/oud.jpg",
                              ImageThumbnail = "/images/oud.jpg",
                              InStock = true,
                              IsPreferredProduct = false,
                              ProductCategory = ProductCategories["Perfumes"],
                          },
                           new Product
                           {
                               Name = "Beloved",
                               ProductPrice = 9000,
                               ShortProductDetails = "Body cream with essential oil",
                               LongProductDetails = "",
                               Image = "/images/beloved.jpg",
                               ImageThumbnail = "/images/beloved.jpg",
                               InStock = true,
                               IsPreferredProduct = false,
                               ProductCategory = ProductCategories["Skin Care Products"],
                           }
                      );
                }
                context.SaveChanges();
            }
        }

        private static Dictionary<string, ProductCategory> productCategories;

        public static Dictionary<string, ProductCategory> ProductCategories
        {
            get
            {
                if (productCategories == null)
                {
                    var categoryList = new ProductCategory[]
                    {
                       new ProductCategory{ ProductCategoryName = "Skin Care Products", ProductCategoryDetails = "All Skin Care Products"},
                       new ProductCategory{ ProductCategoryName = "Perfumes", ProductCategoryDetails = "All Perfumes"},
                       new ProductCategory{ ProductCategoryName = "Hair Care Products", ProductCategoryDetails = "All Hair Care Products"},
                       new ProductCategory{ ProductCategoryName = "Face Care Products", ProductCategoryDetails = "All Face Care Products"}
                    };

                    productCategories = new Dictionary<string, ProductCategory>();

                    foreach (ProductCategory category in categoryList)
                    {
                        productCategories.Add(category.ProductCategoryName, category);
                    }
                }
                return productCategories;
            }

        }

    }

       
    
}
