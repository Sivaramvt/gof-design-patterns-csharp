using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class BreadOrder:IOrder
    {

        #region IOrder Members

        public void Prepare()
        {
            Console.WriteLine("Preparing bread...");
        }

        public int GetPrice()
        {
            return 100;
        }

        #endregion
    }
}
