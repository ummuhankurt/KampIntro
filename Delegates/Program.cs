using System;

namespace Delegates
{
    class Program
    {
        // Delegates.
        public delegate void MyDelegate(); // void döndüren ve parametre almayan metodlara delegelik yapıyor.
        public delegate string MyDelegate2(string text);
        public delegate void MyDelegate3(string text);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MyDelegate MyDelegate = customerManager.SendMessage;
            MyDelegate += customerManager.ShowAlert;
            MyDelegate -= customerManager.SendMessage;
            MyDelegate2 myDelegate2 = customerManager.ReturnText;
            MyDelegate3 myDelegate3 = customerManager.ShowText;
            myDelegate3("Ümmühan");
            MyDelegate();
            Console.WriteLine(myDelegate2("skjgj"));
        }
    }
    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }
        public string ReturnText(string text)
        {
            return text;
        }
        public void ShowText(string text)
        {
            Console.WriteLine("This is " + text);
        }
    }
}
