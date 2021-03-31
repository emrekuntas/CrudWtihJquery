using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore
{
    public static class TestVerileri
    {
        public static void Seed() 
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count()==0)
            {

                if (context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }

            }

            context.SaveChanges();
        }
        private static Product[] Products =
        {
            new Product(){Barcode="1214",Price=14,Description="Telefon",ImageUrl="1.jpg",Piece=1,IsDeleted=0},
            new Product(){Barcode="1714",Price=12,Description="Bilgisayar",ImageUrl="2.jpg",Piece=2,IsDeleted=0},
            new Product(){Barcode="1231",Price=46,Description="Araba",ImageUrl="3.jpg",Piece=3,IsDeleted=0},
            new Product(){Barcode="3214",Price=36,Description="Çanta",ImageUrl="4.jpg",Piece=4,IsDeleted=0},
        };

    }
}
