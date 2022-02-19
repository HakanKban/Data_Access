using EF_CODEFIRST_WFA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Context
{
    internal class MyContext: DbContext
    {
      public MyContext() : base("Connection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasOptional(x => x.Profile).WithRequired(x => x.AppUser); // birebir ilişki
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // tekilleştirme çoğullaştırma yapmaz


            // Çoka çok ilişki
            modelBuilder.Entity<OrderAndProduct>().Ignore(x => x.ID); // basedeki ID yi sqle göndermemek için 
            modelBuilder.Entity<OrderAndProduct>().HasKey(x => new { x.OrderID, x.ProductId }); // composite key


        }
        public DbSet<AppUser> appUsers { get; set; }
        public DbSet<AppUserDetail> appUserDetails { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public  DbSet<OrderAndProduct> OrderAndProducts { get; set; }

    }
}
