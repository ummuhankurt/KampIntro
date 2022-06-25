using EntityFrameworkDemo.DataAccess;
using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.Bussiness
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}
