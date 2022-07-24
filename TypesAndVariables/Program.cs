using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // int -> -2147483648 ile 2147483647 arasındaki değerleri tutar.
            int number1 = 2147483647;
            int number2 = 50;
            Console.WriteLine("Number1 is {0} \nNumber2 is {1}",number1,number2);
            // long -> integerin iki katı kadar yer kaplar.
            // long -> 19 karakterlik yer tutar.
            // -9223372036854775808 ile 9223372036854775807 arasındaki değerleri tutar.
            long number3 = 2147483649;
            Console.WriteLine("Number3 is {0}", number3);
            // short -> -32768 ile 32767 arasında yer alır.
            short number4 = -32768;
            Console.WriteLine("Number4 is {0}" , number4);
            // byte -> 0 ile 255 arasında değer alır.
            byte number5 = 255;
            Console.WriteLine("Number5 is {0}",number5);
            // bool -> mantıksal operatör.
            bool condition = true; // or false.
            // char tek bir karakter tutar. Tek tırnak kullanılır.
            // ASCII tablosundaki değerini öğrenmek için ; (int)character
            char character = 'A';
            Console.WriteLine("The character is {0}" , character);
            // double -> noktalı sayılar.
            double number6 = 10.5;
            Console.WriteLine("Number6 is {0}", number6);
            // integer için long ne ise, double için de decimal odur.
            // 2xint = long , 2xdouble = decimal
            // decimal daha hassas. Örneğin para değerleri için decimal kullanılabilir.
            // Double virgülden sonra 15 16 tane sayı tutabiliyorken , decimal virgülden sonra 27 tane sayı tutabilir.
            // Tanımlarken sayının sonuna m harfi konulmalıdır.
            decimal number7 = 10.456986547985652365698756486m;
            Console.WriteLine("Number7 is {0}",number7);
            // Enum 
            // Friday 'in Enum içindeki index numarasını öğrenmek için ; (int)Days.Friday
            Console.WriteLine(Days.Friday);
            // Var keywordü
            var number8 = 10; // ilk atama int olduğu için, bundan sonra bu değişkene yapılacak her atama integer olarak kabul edilir.
            number8 = 'A';
            Console.WriteLine("Number8 is {0}",number8);

        }
    }
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
