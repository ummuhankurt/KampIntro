using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,6);
            dortIslem.Cikar(5, 6);
            dortIslem.Carp(5, 6);
            dortIslem.Bol(5, 6);
        }
    }
}
