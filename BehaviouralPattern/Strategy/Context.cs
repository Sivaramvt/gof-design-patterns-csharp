using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Context
    {
        private IAlgorithm _Strategy;

        public void SetStrategy(IAlgorithm strategy)
        {
            this._Strategy = strategy;
        }

        public int calculate(int no1, int no2)
        {
           return _Strategy.Calculate(no1, no2);
        }
    }
}
