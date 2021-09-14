using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cosmetic_hub__e_shopping_system_.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class AppDbContext :IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ShoppingCartItems> ShoppingCartItems { get; set; }

        public DbSet<ProductOrder> ProductOrders { get; set; }

        public DbSet<ProductOrderDetail> ProductOrderDetails { get; set; }
    }
}
