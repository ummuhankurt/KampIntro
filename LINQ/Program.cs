using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
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
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop",QuantityPerUnit = "16 gb Ram",UnitPrice = 8000,UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "HP Laptop",QuantityPerUnit = "8 gb Ram",UnitPrice = 6000,UnitsInStock = 23},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon",QuantityPerUnit = "4 gb Ram",UnitPrice = 5000,UnitsInStock = 12},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon",QuantityPerUnit = "4 gb Ram",UnitPrice = 8000,UnitsInStock = 0}
            };

            foreach (var item in GetProductsLinq(products))
            {
                Console.WriteLine(item.ProductName);
            }
           
        }
        // Linq olmasaydı yazacağımız kod;
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>(); // Linq olmasaydı bu şekilde yeni bir liste oluşturmak zorundaydık.
            foreach (var product in products)
            {
                if(product.UnitsInStock > 5 && product.UnitPrice > 5000)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            // Linq hem bize yeni bir liste oluşturur hem de şartları kontrol eder. 
            //ToList() -> IEnumerable olan yapıyı listeye dönüştürür.
            return products.Where(p => p.UnitsInStock > 5 && p.UnitPrice > 5000).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; } // PK
        public int CategoryId { get; set; } // FK
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; } // PK
        public string CategoryName { get; set; }
    }
}
