using AOPDemo.Business.Abstract;
using AOPDemo.Core.Aspects.Logging;
using AOPDemo.Core.CrossCuttingConcerns.Caching.Abstract;
using AOPDemo.Core.CrossCuttingConcerns.Logging;
using AOPDemo.DataAccess.Abstract;
using AOPDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [LogAspect]
        public List<Product> GetAll()
        {
            // Business codes. Authority control etc.
            return _productDal.GetAll();
        }
    }
}
