using System;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Product harddisk = new Product(50) { ProductName = "Harddisk"};
            Product gsm = new Product(50) { ProductName = "Telefon" };
            gsm.StockControlEvent += Gsm_StockControlEvent;
            for (int i = 0; i < 10; i++) 
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("gsm about to finish");
        }
    }
}
