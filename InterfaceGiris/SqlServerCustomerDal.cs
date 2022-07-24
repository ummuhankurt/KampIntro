using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGiris
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql' kaydedildi");
        }

        public void Delete()
        {
            Console.WriteLine("Sql'den silindi");
        }

        public void Update()
        {
            Console.WriteLine("Sql de güncellendi");
        }
    }
}
