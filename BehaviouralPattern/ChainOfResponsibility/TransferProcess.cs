using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class TransferProcess:AbstractProcess
    {
        public override void Process()
        {
            Console.WriteLine("-----------Transfer Process-------------");

            if (_next != null)
            {
                _next.Process();
            }
        }
    }
}
