using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.DataAccessor.Entities;
using System;

namespace Rookie.Ecom.DataAccessor.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Flutent API
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(entity =>
            {
                entity.ToTable(name: "AppUser");
            });
            builder.Entity<AppRole>(entity =>
            {
                entity.ToTable(name: "AppUser");
            });

            builder.Entity<Category>(entity =>
            {
                entity.ToTable(name: "Category");
            });
            builder.Entity<Order>(entity =>
            {
                entity.ToTable(name: "Order");
            });
            builder.Entity<OrderItems>(entity =>
            {
                entity.ToTable(name: "OderItems");
            });
            builder.Entity<Product>(entity =>
            {
                entity.ToTable(name: "Product");
            });
            builder.Entity<ProductRating>(entity =>
            {
                entity.ToTable(name: "ProductRating");
            });
            builder.Entity<ShoppingCart>(entity =>
            {
                entity.ToTable(name: "ShoppingCart");
            });
            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<ShoppingCartDetail>(entity =>
            {
                entity.ToTable(name: "ShoppingCartDetail");
            });
        }
    }
}
