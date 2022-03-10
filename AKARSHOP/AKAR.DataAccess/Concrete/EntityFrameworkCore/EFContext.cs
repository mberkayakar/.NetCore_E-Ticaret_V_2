using AKAR.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Concrete.EntityFrameworkCore
{
    public class EFContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // dur aq defaıultta startup seçili ya bi saniye 

            // çözdüm sanırım 
            optionsBuilder.UseSqlite("Data Source=AKARDB");
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c => new {c.CategoryID,c.ProductId});

        }

    }
}
