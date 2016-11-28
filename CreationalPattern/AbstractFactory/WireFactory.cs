using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class WireFactory : AbstractComputerFactory
    {
        #region IFactory Members

        public override IProduct GetProduct(string name)
        {
            if (name == "usb")
                return new USBWire();
            else if (name == "powercord")
                return new PowerCordWire();
            else
                return null;
        }

        #endregion
    }
}
