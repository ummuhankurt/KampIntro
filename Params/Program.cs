using System;
using System.Linq;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(999,5, 6, 6, 5, 6, 5, 8, 9, 9, 8, 8, 8));
        }
        static int Add(int number , params int[] numbers)
        {
            Console.WriteLine("Number is {0}",number);
            return numbers.Sum();   
        }
    }
}
