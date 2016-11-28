using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractComputerFactory
    {
        public static AbstractComputerFactory GetFactory(string name)
        {
            if (name == "component")
            {
                return new ComponentFactory();
            }
            else if (name == "wire")
            {
                return new WireFactory();
            }
            else
                return null;
        }

       abstract public IProduct GetProduct(string name);
    }
}
