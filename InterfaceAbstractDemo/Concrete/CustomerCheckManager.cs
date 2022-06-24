using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class MernisServiceReferenceAdapter : ICustomerCheckService
    {
        // Bu bizim kendi servisimiz.
        public bool CheckIfRealPerson(Customer customer)
        {
            
            return true;
        }
    }
}
