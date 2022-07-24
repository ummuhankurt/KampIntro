using AOPDemo.Business.Concrete;
using AOPDemo.DataAccess.Abstract;
using AOPDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { Id = 1 , Name = "Laptop"},
                new Product { Id = 2, Name = "Mouse"}
            };
        }
    }
}
