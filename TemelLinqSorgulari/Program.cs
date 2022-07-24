using System;
using System.Collections.Generic;
using System.Linq;

namespace TemelLinqSorgulari
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName ="Bilgisayar"},
                new Category {CategoryId = 2 ,CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop",QuantityPerUnit = "32 gb Ram",UnitPrice = 10000,UnitsInStock = 5},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop",QuantityPerUnit = "16 gb Ram",UnitPrice = 10000,UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "HP Laptop",QuantityPerUnit = "8 gb Ram",UnitPrice = 6000,UnitsInStock = 23},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon",QuantityPerUnit = "4 gb Ram",UnitPrice = 5000,UnitsInStock = 12},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon",QuantityPerUnit = "4 gb Ram",UnitPrice = 8000,UnitsInStock = 0}
            };
            // Any fonksiyonu linq'in bir fonksiyonudur. Listede aradığımız elaman var mı yok mu kontrol eder.Bool değer döner.
            // Eğer bu sorgu olmasaydı for ile dönüp tek tek kontrol etmemiz gerekecekti.
            Console.WriteLine(products.Any(p => p.ProductName == "Dell Laptop"));
            Console.WriteLine("-------------------------------");
            // Aranan kritere uygun nesnenin kendisini döner. Kritere uygun nesne bulunmazsa hata verir.
            Console.WriteLine(products.Find(p => p.ProductId == 5).ProductName);
            Console.WriteLine("-------------------------------");
            // FindAll ise şarta uyan bütün elemanları getirir. Şarta uygun eleman yoksa hiçbir şey göstermez
            List<Product> filteredProduct = products.FindAll(p => p.ProductName.Contains("Tel"));
            foreach (var item in filteredProduct)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("-------------------------------");
            // isminde top geçen ürünlerin fiyatlarını küçükten büyüğe doğru sırala. Fiyatı aynı olan varsa da adlarını alfabetik sırala.
            // Single line query.
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).OrderByDescending(p=> p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("-------------------------------");
            // Join Operasyonları ve DTO
            var sonuc = from p in products
                        join c in categories on p.CategoryId equals c.CategoryId
                        where p.UnitPrice > 6000 orderby p.UnitPrice descending
                        select new ProductDTO { CategoryId = c.CategoryId, CategoryName = c.CategoryName, ProductName = p.ProductName ,
                            UnitPrice = p.UnitPrice };
            foreach (var productDTO in sonuc)
            {
                Console.WriteLine("Category ID : " + productDTO.CategoryId + " " + " Category Name : " + productDTO.CategoryName + 
                    " " + "Product Name : " + productDTO.ProductName + " Fiyat : " + productDTO.UnitPrice);
            }

        }
        class Product
        {
            public int ProductId { get; set; } // PK
            public int CategoryId { get; set; } // FK
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public int UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }
        class Category
        {
            public int CategoryId { get; set; } // PK
            public string CategoryName { get; set; }
        }
        class ProductDTO
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public int UnitPrice { get; set; }
        }
    }
}
