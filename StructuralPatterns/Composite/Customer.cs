using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Customer:INode
    {
        private string _name;
        public List<Address> addresses = new List<Address>();
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
            addresses.Add((Address)o);
        }

        #endregion

        #region INode Members


        public List<Address> connectedNode
        {
            get { return addresses; }

        }

        #endregion
    }
}
