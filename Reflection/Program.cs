using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,5);
            //Console.WriteLine(dortIslem.Topla(2, 5));
            //Console.WriteLine(dortIslem.Topla2());
            var tip = typeof(DortIslem);
            // Activator.CreateInstance(tip); -> Obje döndürür.
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,5,8);
            //Console.WriteLine(dortIslem.Topla(5,8));
            //Console.WriteLine(dortIslem.Topla2());
            var instance = Activator.CreateInstance(tip,5,8); // instance'ın tipi Person
            // Invoke(null) Böyle olunca sadece metod bilgisine ulaşıyor.Neresi için çalıştıracağını bilmiyor.
            // GetMethod ile istediğin metoda ulaşabiliyorsun,Invoke ile onu çalıştırabiliyorsun.
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("********************");
            var metodlar = tip.GetMethods();
            foreach (var metod in metodlar)
            {
                Console.WriteLine("Metod adı : {0}",metod.Name);
                foreach (var parameters in metod.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}",parameters.Name);
                }
                foreach (var attribute in metod.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute : {0}" , attribute.GetType().Name);
                }
            }

            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (var item in assembly.GetTypes())
            {
                Console.WriteLine(item.Name);
            }

            var personType = typeof(Person);
            var personInstance = Activator.CreateInstance(personType);
            var nameProp = personType.GetProperty("Name");
            nameProp.SetValue(personInstance, "Ümmühan");
            Console.WriteLine(nameProp.GetValue(personInstance));
            //  personInstance.GetType() eşittir personType
            var personMetodInfo = personInstance.GetType().GetMethod("CheckStatus");
            Console.WriteLine(personMetodInfo.Invoke(personInstance, null));

        }
    }
    class DortIslem 
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        [MetodName("Parametreli toplama")]
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        [MetodName("Parametresiz toplama")]
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
    }
    class MetodNameAttribute : Attribute
    {
        string _metodName;
        public MetodNameAttribute(string metodName)
        {
            _metodName = metodName;
        }
    }
    public class Person
    {
        public string  Name { get; set; }
        public void CheckStatus()
        {
            Console.WriteLine("Checked");
        }
    }
}
