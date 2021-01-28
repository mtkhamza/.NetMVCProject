using MVCApp.Models;
using Microsoft.EntityFrameworkCore;
namespace MVCApp
{
    public class CatalogueDbRepository:DbContext{
        public DbSet<Category> Categories {get;set;}
        public DbSet<Product> Products { get; set; }
        public CatalogueDbRepository(DbContextOptions options):base(options)
        {
            
        }
    }
}