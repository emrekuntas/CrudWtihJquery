using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal:EfCoreGenericRepository<Product,ShopContext>,IProductDal
    {


    }
}
