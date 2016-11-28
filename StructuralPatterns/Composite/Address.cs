using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Address:INode
    {
        private string _name;
        public List<PhoneNos> _phoneNos = new List<PhoneNos>();
        #region INode Members

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void Add(object o)
        {
            _phoneNos.Add((PhoneNos)o);
        }

        #endregion

        #region INode Members


        public List<PhoneNos> connectedNode
        {
            get
            {
                return _phoneNos;
            }
        }

        #endregion
    }
}
