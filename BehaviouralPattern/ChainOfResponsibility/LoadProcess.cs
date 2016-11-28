using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class LoadProcess:AbstractProcess
    {
        public override void Process()
        {
            Console.WriteLine("-----------Load Process-------------");

            if (_next != null)
            {
                _next.Process();
            }
        }
    }
}
