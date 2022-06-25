using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
