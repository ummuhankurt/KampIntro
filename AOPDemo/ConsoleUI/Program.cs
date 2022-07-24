using AOPDemo.Business.Abstract;
using AOPDemo.Business.Concrete;
using AOPDemo.Core.CrossCuttingConcerns.Caching.Concrete;
using AOPDemo.Core.CrossCuttingConcerns.Logging.Concrete;
using AOPDemo.DataAccess.Concrete.EntityFramework;
using AOPDemo.DataAccess.Concrete.Nhbirnate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // console ui.
            IProductService productService = new ProductManager(new EfProductDal());
            foreach (var item in productService.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
