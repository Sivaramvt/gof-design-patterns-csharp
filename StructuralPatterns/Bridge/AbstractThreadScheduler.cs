using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    abstract class AbstractThreadScheduler
    {
        protected IPlatformImplementation _impl;

        protected AbstractThreadScheduler(IPlatformImplementation impl)
        {
            _impl = impl;
        }
        
        public abstract void ScheduleJob();
    }
}
