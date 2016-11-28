using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class PhoneNumber:ICustomerInfo
    {
        #region ICustomerInfo Members

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        #endregion

        public PhoneNumber(String no)
        {
            _PhoneNumber = no;
        }

        public string _PhoneNumber;
    }
}
