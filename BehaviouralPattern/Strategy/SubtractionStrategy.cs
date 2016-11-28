using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class SubtractionStrategy:IAlgorithm
    {
        public int Calculate(int no1, int no2)
        {
            return no1 - no2;
        }
    }
}
