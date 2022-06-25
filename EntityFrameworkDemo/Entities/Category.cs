using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.Entities
{
    public class Category : IEntity
    {
        public int CategorId { get; set; }
        public string CategoryName { get; set; }

    }
}
