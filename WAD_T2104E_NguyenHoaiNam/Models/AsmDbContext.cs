using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenHoaiNam.Models
{
    public class AsmDbContext : DbContext
    {
        public AsmDbContext() : base("AsmDb")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public AsmDbContext(DbSet<Product> products, DbSet<Category> categories)
        {
            Products = products;
            Categories = categories;
        }
    }
}