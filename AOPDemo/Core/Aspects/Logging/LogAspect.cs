using AOPDemo.Core.CrossCuttingConcerns.Logging;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOPDemo.Core.Aspects.Logging
{
    //IL Weaving.Intermediate language branching.
    //Method Interception
    [Serializable]
    public class LogAspect : OnMethodBoundaryAspect
    {

        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Logged");
        }
    }
}
