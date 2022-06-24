using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        // İki firmada da save metodu ortak olduğu için abstract olarak tanımlıyoruz.
        // Starbucks Save işlemi yaparken, mernis doğrulaması istediği için, bu metodu virtual yapıp StarbucksManagerda eziyoruz
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db " + customer.FirstName);
        }
    }
}
