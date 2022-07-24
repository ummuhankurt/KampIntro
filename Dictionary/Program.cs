using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1) Dictionary sınıfı içinde sizin belirleyeceğiniz bir key e uygun olarak değer saklar.Zorunlulugu var.
            2) Key türünü belirlemeniz şart (string,int, decimal,float...)
             */
            Dictionary<string, int> adYas = new Dictionary<string, int>();
            // veri ekliyoruz.
            adYas.Add("Amy", 25);
            adYas.Add("Mehmet", 17);
            adYas.Add("Birisi", 30);
            foreach (var item in adYas)
            {
                Console.WriteLine("key : " + item.Key);
                Console.WriteLine("value : " + item.Value);
            }
            // deger sayma özelliği vardır ;
            var eleman = adYas.Count();
            Console.WriteLine("eleman sayısı : " + eleman);
            // silme işlemi vardır
            adYas.Remove("Birisi");
            foreach (var item in adYas)
            {
                Console.WriteLine("key : " + item.Key);
                Console.WriteLine("value : " + item.Value);
            }
        }
    }
}
    