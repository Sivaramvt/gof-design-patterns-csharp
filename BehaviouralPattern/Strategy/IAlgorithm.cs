using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public interface IAlgorithm
    {
        int Calculate(int no1, int no2);
    }
}
