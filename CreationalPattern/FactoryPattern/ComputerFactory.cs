using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class ComponentFactory
    {
        public static IComponent GetComponent(string componentName)
        {
            if (componentName.ToLower() == "Screen".ToLower())
                return new Screen();
            else if(componentName.ToLower() == "CPU".ToLower())
                return new CPU();
            else
                return null;
        }
    }
}
