using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class CPU: IComponent
    {
        #region IComponent Members

        public int GetWeight()
        {
            return 500;
        }

        #endregion
    }
}
