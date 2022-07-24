using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi oluşturduktan sonra yeni eleman ekleyemezsin. Bu yüzden koleksiyonlara ihtiyaç duyarız.
            List<string> isimler = new List<string> { "Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("İlker");
            Console.WriteLine(isimler[4]);


        }
    }
}    
