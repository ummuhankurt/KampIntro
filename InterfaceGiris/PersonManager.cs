using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGiris
{
    class PersonManager 
    {
        public void Add(List<ICustomerDal> customerDals)
        {
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

    }
}
