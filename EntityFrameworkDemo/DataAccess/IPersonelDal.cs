using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.DataAccess
{
    public interface IPersonelDal : IEntityRepository<Personel>
    {
    }
}
