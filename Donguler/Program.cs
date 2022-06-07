using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrayler
            string[] kurslar = new string[] { "Yazılım Geliştirici Geliştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs","Python","Java","C#"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine((i+1) + ". Kurs : " + kurslar[i]);
            }
            Console.WriteLine("********************");
            foreach (string item in kurslar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Footer - Sayfa sonu");
        }
    }
}
