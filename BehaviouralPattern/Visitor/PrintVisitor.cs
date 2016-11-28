using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class PrintVisitor:IVisitor
    {

        #region IVisitor Members

        public void visit(Customer cust)
        {
            Console.WriteLine("Customer: {0}", cust._Name);
        }

        public void visit(Address address)
        {
            Console.WriteLine("Address: {0}", address._address);
        }

        public void visit(PhoneNumber phone)
        {
            Console.WriteLine("Phone #: {0}", phone._PhoneNumber);
        }

        #endregion
    }
}
