using Microsoft.EntityFrameworkCore;
using NLayer.Core.Model;
using NLayer.Repository.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //options ile veri tabanı yolunu startup dosayasından vereceğiz
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {   //product feature seed datalarını buradan çektik

                Id = 1,
                Color = "Kirmizi",
                Heihgt = 100,
                Width = 200,
                ProductId = 1

            },
            new ProductFeature()
            {
                Id = 2,
                Color = "Mavi",
                Heihgt = 300,
                Width = 500,
                ProductId = 2,

            });

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-23LHKUG;Database=B2BDb;Trusted_Connection=True;"));
        //}
    }

}
