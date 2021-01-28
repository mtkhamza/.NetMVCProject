using MVCApp.Models;
namespace MVCApp.Services
{
    public static class DbInit
    {
        public static void initData(CatalogueDbRepository CatalogueDb){
            CatalogueDb.Categories.Add(new Category{Name="Laptop"});
            CatalogueDb.Categories.Add(new Category{Name="Printer"});
            CatalogueDb.Products.Add(new Product{Name="Hp",Price=5000,CategoryID=1});
            CatalogueDb.Products.Add(new Product{Name="Canon",Price=500,CategoryID=2});
            CatalogueDb.Products.Add(new Product{Name="Dell",Price=7000,CategoryID=1});
            CatalogueDb.Products.Add(new Product{Name="Lg",Price=450,CategoryID=2});
            CatalogueDb.SaveChanges();
        }
    }
}