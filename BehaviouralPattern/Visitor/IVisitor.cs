using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    interface IVisitor
    {
        void visit(Customer cust);
        void visit(Address address);
        void visit(PhoneNumber phone);
    }
}
