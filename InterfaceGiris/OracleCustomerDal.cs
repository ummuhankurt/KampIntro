using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGiris
{
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle'a eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle' dan silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle ' da güncellendi");
        }
    }
}
