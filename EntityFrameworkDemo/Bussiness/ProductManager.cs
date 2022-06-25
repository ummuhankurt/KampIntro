using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            if(product.ProductName == "Laptop")
            {
                throw new Exception("Laptop Ekleyemezsiniz");
            }
            else
            {
                _productDal.Add(product);
            }
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            // iş kodları
           return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
