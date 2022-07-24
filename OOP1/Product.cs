using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
   
    class Product // Entitiy
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // Referans alanları. Foreginkey.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        

    }
}
