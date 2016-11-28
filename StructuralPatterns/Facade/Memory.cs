using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class HDD
    {
        public void SupplyPower()
        {
            Console.WriteLine("HDD - Power supply provided");
        }

        public void FetchData()
        {
            Console.WriteLine("HDD - Fetch data");
        }

        public void StoreData()
        {
            Console.WriteLine("HDD - Storing data");
        }
    }
}
