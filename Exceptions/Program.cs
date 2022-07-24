using KininTech.SqlMapping.Exceptions;
using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionDemo(); // Özel bir tipi döndürmeyen kod blokları için kullanılır. 
            // Func<int> parametre almayan, int değer döndüren metoda delege ediyor.
            Func<int> getRandomNumber = RandomNumber;
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());
            // int tipinde iki tane parametre alan, int tipinde değer döndüren fonksiyona delege ediyor.
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(5,8));
        }
        public static int RandomNumber()
        {
                Random random = new Random();
                return random.Next(1,100);
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        public static void Find()
        {
            List<string> isimler = new List<string> { "Ali", "Ayşe", "Mehmet" };
            if (!isimler.Contains("Ümmühan"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record found");
            }
        }
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
