using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Calisma();
            ornek.Y = 5;
            ornek.X();
            ornek.W();
        }
    }

    abstract class Ornek
    {
        abstract public void X();
        public abstract int Y { get; set; }
        public void W()
        {
            Console.WriteLine("Ortak");
        }
    }

    class Calisma : Ornek
    {
        public override int Y { get; set ; }

        public override void X()
        {
            Console.WriteLine("Ezdim. Calismanin x metodu.");
        }
    }














    // Absractla işaretlenen metodlar ve propertyler bu sınıftan kalıtım alan her sınıfta uygulanmak zorundadır.
    // Abstract metod ya da propertylerin gövdeleri tanımlandıkları class içinde yazılmazlar. Gövdeleri kalıtım alan sınıfta ovverride edilerek yazılır.
    // Bir abstract sınıf içerisinde abstract olan elemanlar varken, abstract olmayan elemanlarda olabilir.
    // Abstract elemanlar private olamazlar. Public veya protected olarak tanımlanırlar.
    // Abstract classlardan nesne oluşturulamaz.
    //abstract class MyClass
    //{
    //    //public void X()
    //    //{

    //    //}
    //    //public int MyProperty { get; set; }
    //    //private int myVar; -> Bu bir field. Property değil. Ve fieldlar abstract olarak tanımlanamazlar.

    //    public abstract void X();
    //    abstract public int MyProperty { get; set; }
    //}
}
