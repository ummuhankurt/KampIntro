using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Core.CrossCuttingConcerns.Logging
{
    public interface ILogger
    {
        void Log();
    }
}
