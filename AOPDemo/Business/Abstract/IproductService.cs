using AOPDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Business.Abstract
{
    public interface IProductService
    {
        public List<Product> GetAll();
    }
}
