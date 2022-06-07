using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int a ,int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }
        public void Cikar(int a, int b)
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b));
        }
        public void Carp(int a, int b)
        {
            Console.WriteLine(a + " . " + b + " = " + (a * b));
        }
        public void Bol(double a, double b)
        {
            Console.WriteLine(a + " / " + b + " = " + (a / b));
        }
    }
}
