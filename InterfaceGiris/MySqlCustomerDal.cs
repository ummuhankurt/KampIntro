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
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
