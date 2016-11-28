using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Address : ICustomerInfo
    {
        #region ICustomerInfo Members

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);

            foreach (PhoneNumber phone in _PhoneNoList)
                phone.accept(visitor);
        }

        #endregion

        public Address(String no)
        {
            _address = no;
            _PhoneNoList = new List<PhoneNumber>();
            _PhoneNoList.Add(new PhoneNumber("1234"));
            _PhoneNoList.Add(new PhoneNumber("12345"));
        }

       public string _address;
        List<PhoneNumber> _PhoneNoList;
    }
}
