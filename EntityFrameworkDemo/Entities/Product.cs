﻿using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; } // Int16 da shorta karşılık gelir.

    }
}
