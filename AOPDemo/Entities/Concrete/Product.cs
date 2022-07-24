using AOPDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
