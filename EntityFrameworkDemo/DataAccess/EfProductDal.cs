using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EntityFrameworkDemo
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                context.SaveChanges();
            }
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                // singleordefaultta şarta uygun birden fazla data varsa hata döner.
                // firstalldefaultta şarta uygun birden fazla data varsa hata vermez.İlk datayı verir.
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            // disposible pattern
            using (NorthwindContext contex = new NorthwindContext())
            {
                return filter == null ? contex.Set<Product>().ToList() : contex.Set<Product>().Where(filter).ToList();
            }
            
        }

        public void Update(Product product)
        {
            using (NorthwindContext contex = new NorthwindContext())
            {
                var productToUpdate = contex.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
                contex.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
