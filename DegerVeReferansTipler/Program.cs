using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); // 30.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); // 999.

            // int,decimal,float,double, bool -> Değer Tip.
            // array, class,interface -> Referans Tip.
            // Stack -> Değer tipler
            // Heap -> Referans tipler.

            int number1 = 20;
            int number2 = 100;
            Console.WriteLine(Add(ref number1,number2));
            Console.WriteLine("Number1 is {0}",number1);
        }
        static int Add(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int refOut(out int number3)
        {
            number3  = 50;
            return number3;
        }
    }
}
