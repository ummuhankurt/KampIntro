using System;
using System.Collections.Generic;

namespace InterfaceGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personMananager = new PersonManager();
            List<ICustomerDal> customerDals = new List<ICustomerDal> // Polimorfinizm.
            {
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            personMananager.Add(customerDals);
        }
    }
}
