using DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);/*NorthwindContext için herhangi bir migration datası vermiyoruz. Veritabanının kod tarafından üretilmesini engellemek için.*/
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //northwind dbsindeki tablolar eklenecek.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//mappingi ayağa kaldırıyoruz.
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            //diğer maplerde eklenmeli.
        }
    }
}
