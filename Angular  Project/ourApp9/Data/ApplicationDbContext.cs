using Microsoft.EntityFrameworkCore;
using ourApp9.Models;

namespace ourApp9.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyInfo>().HasData(
                new CompanyInfo { CId = 1, CName = "Samsung" },
                new CompanyInfo { CId = 2, CName = "HP" },
                new CompanyInfo { CId = 3, CName = "Apple" },
                new CompanyInfo { CId = 4, CName = "Dell" },
                new CompanyInfo { CId = 5, CName = "Toshiba" },
                new CompanyInfo { CId = 6, CName = "Redmi" }
                );

            modelBuilder.Entity<ProductInfo>().HasData(
               new ProductInfo { Id = 101, PName = "Samsung",PPrice=12000,CId=1 }
          
               );
        }

    }

}
