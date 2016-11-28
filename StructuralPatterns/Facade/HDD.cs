using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Memory
    {
        public void SupplyPower()
        {
            Console.WriteLine("Memory - Power supply provided");
        }

        public void AllocateMemory()
        {
            Console.WriteLine("Memory - Allocating memory");
        }
    }
}
