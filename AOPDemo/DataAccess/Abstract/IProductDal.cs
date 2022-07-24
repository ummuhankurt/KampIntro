using AOPDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}
