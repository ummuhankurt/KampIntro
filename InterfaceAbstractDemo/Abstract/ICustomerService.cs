using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        public void Save(Customer customer);
    }
}
