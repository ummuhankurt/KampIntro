using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Core.CrossCuttingConcerns.Caching.Abstract
{
    public interface ICache
    {
        void Cache();
    }
}
