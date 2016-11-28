using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    interface IOrder
    {
        void Prepare();
        int GetPrice();
    }
}
