using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class USBWire: IWire
    {
        #region IWire Members

        public int GetWeight()
        {
            return 10;
        }

        #endregion
    }
}
