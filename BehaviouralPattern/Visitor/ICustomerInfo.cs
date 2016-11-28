using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    interface ICustomerInfo
    {
        void accept(IVisitor visitor);
    }
}
