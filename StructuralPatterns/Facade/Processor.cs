using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Processor
    {
        public void SupplyPower()
        {
            Console.WriteLine("Processor - Power supply provided");
        }

        public void Execute()
        {
            Console.WriteLine("Processor - Executing");
        }

        public void LoadCode()
        {
            Console.WriteLine("Processor - Loading code into memory");
        }
    }
}
