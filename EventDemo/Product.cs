using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    public delegate void StockControl();
    public class Product
    {
        public int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                if(value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
                _stock = value;
            }
        }
        public void Sell(int amount)
        {
            if(amount <= Stock)
            {
                Stock -= amount;
            }
            
            Console.WriteLine("{1} Stock : {0}" , Stock,ProductName);
        }
    }
}
