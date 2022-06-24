using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            // Mernis kontrolü...
            // Burada kontrol yapabilirsin ama yarın diğer firmada kontrol isteyebilir. O yüzden buraya yazmak mantıklı değil.
            // ICustomerCheckKontrol adında interface oluşturup kontrol metodunu orada tanımlamalıyız.
            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
