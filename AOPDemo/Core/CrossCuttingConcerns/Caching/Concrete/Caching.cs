using AOPDemo.Core.CrossCuttingConcerns.Caching.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Core.CrossCuttingConcerns.Caching.Concrete
{
    public class Caching : ICache
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }
}
