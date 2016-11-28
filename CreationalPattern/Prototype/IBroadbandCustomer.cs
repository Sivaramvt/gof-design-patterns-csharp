using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    interface IBroadbandCustomer:ICloneable
    {
        string Name { get; set; }
    }
}
