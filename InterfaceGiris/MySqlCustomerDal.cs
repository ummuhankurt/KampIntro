using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGiris
{
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql'e eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql' den silindi");
        }

        public void Update()
        {
            Console.WriteLine("Mysql'de güncellendi");
        }
    }
}
