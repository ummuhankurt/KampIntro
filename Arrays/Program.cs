using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[] { "Derin","Engin","Salih"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }
        
    }
}
