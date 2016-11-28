using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class ExtractProcess:AbstractProcess
    {
        public override void Process()
        {
            Console.WriteLine("-----------Extract Process-------------");

            if (_next != null)
            {
                _next.Process();
            }
        }
    }
}
