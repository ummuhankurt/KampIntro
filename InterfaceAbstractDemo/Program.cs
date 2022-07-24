using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new Adapters.MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { Id = 1, FirstName = "Ümmühan", LastName = "Kurt",DateOfBirth = new DateTime(1998,8,22),NationalityId = "222222222"});
        }
    }
    
}
