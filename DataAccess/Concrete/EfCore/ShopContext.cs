using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        public ShopContext()
        {
                
        }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=shopDB;Integrated Security=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
