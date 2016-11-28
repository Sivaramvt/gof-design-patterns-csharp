using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class PhoneNos:INode
    {
        private string _name;
        
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
            
        }

        #endregion

        #region INode Members


        public List<INode> connectedNode
        {
            get { return null; }
        }

        #endregion
    }
}
