using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class VodafoneCustomer : IBroadbandCustomer, ICloneable
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }   
        
        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
