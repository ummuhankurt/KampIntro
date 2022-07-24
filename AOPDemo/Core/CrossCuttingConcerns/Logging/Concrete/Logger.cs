using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Core.CrossCuttingConcerns.Logging.Concrete
{
    public class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
}
