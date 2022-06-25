using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.Bussiness
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
    }
}
