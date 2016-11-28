using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Customer : ICustomerInfo
    {
        #region ICustomerInfo Members

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);

            foreach (Address address in _Address)
                address.accept(visitor);
        }

        #endregion

        public Customer(String no)
        {
            _Name = no;
            _Address = new List<Address>();
            _Address.Add(new Address("1st street"));
            _Address.Add(new Address("2nd street"));
        }

        public string _Name;
        List<Address> _Address;
    }
}
