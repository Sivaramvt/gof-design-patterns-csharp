using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class ComponentFactory: AbstractComputerFactory
    {
        #region IFactory Members

        public override IProduct GetProduct(string name)
        {
            if (name == "mouse")
            {
                return new Mouse();
            }
            else if (name == "cpu")
            {
                return new CPU();
            }
            else
                return null;
        }

        #endregion
    }
}
