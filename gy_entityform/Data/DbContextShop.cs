using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gy_entityform.Models;

namespace gy_entityform.Data
{
    public class DbContextShop : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AMCA\DENEMESERVERSQL; Database=DbShopEntity ;User ID=sa;Password=1432");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().Property(x => x.Name)
                                          .IsRequired()
                                          .HasMaxLength(50);


            modelBuilder.Entity<Product>().HasOne(p => p.Supplier)
                                          .WithMany(s => s.Products)
                                          .HasForeignKey(p => p.SupplierId)
                                          .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ProductsCarts>().HasKey("CartId", "ProductId");

            modelBuilder.Entity<Cart>().HasMany(c => c.Products)
                                       .WithOne(cp => cp.Cart)
                                       .HasForeignKey(x => x.CartId)
                                       .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Product>().HasMany(c => c.Carts)
                                          .WithOne(cp => cp.Product)
                                          .HasForeignKey(x => x.ProductId)
                                          .OnDelete(DeleteBehavior.NoAction);

            
        }
    }
}
