using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class Screen: IComponent
    {
        public int  Price()
        {
            return 5000; 
        }
    }
}
