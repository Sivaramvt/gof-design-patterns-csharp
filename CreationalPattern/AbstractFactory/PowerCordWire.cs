using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class PowerCordWire:IWire
    {
        #region IWire Members

        public int GetWeight()
        {
            return 50;
        }

        #endregion
    }
}
