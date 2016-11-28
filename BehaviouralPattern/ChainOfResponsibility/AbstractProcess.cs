using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    abstract class AbstractProcess
    {
        protected AbstractProcess _next;
        public abstract void Process();
        public void SetNextProcess(AbstractProcess process)
        {
            _next = process;
        }
    }
}
