using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public interface IProductService
    {
        public void Add(Product product);
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Delete(Product product);
        public void Update(Product product);
    }
}
