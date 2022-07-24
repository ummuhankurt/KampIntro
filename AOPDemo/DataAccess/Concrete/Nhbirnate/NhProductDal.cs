using AOPDemo.DataAccess.Abstract;
using AOPDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.DataAccess.Concrete.Nhbirnate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{ Id = 1 , Name = "TV"}
            };
        }
    }
}
