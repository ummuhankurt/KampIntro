using EntityFrameworkDemo.Bussiness;
using EntityFrameworkDemo.DataAccess;
using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET -> Veritabanı kontrol kütüphanesi.Veri listeleme,ekleme,silme,güncelleme, bıdıbıdıdbıdı
            // Entity Framework bir ORM -> Object Relational Mapping(Nesne ilişki bağdaştırması). Nesnelerin veritabanıyla bağdaştırılması.
            ProductManager productManager = new ProductManager(new EfProductDal());
            //productManager.Delete(new Product {ProductId = 1, CategoryId = 2, ProductName = "Masa", QuantityPerUnit = "56", UnitPrice = 500, UnitsInStock = 5 });
            // id si  1 olan ürünün veritabanında ilişkisi olduğu için silemezsin.Config hatası alırsın.
            Console.WriteLine(productManager.GetById(1).ProductName);
            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            Console.WriteLine("Personeller : ");
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var item in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}" , item.Id,item.Name,item.Surname);
            }
        }

        
    }
}
