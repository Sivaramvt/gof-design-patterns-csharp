using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Mouse: IComponent
    {
        public int GetWeight()
        {
            return 100;
        }
    }
}
