using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Stackte oluşturduğun(new'lemediğin) elemanın değerini metotta değiştirirsen ana programa geldiğinde onun değeri metotta atadığın değer olmaz.
             Heapte oluşturduğun(new'lediğin) elemanın değerini metotta değiştirirsen ana programa geldiğinde metotta atadığın değer olur.
             Çünlü new'lediklerin referans şeklinde metoda gider.
             int,bool,double bıdı bıdı değer tip.
             diziler,class,abstract class,interface bıdı bıdı referans tip.
             */
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};
            // PascalCase , camelCase
            // Case sensitive.
            // Referans tiplerin heap'te oluşabilmesi için new'lenmesi gerekir.
            // Sol taraf stack , sağ taraf heap.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



        }
    }
}
