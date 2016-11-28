using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class HeavyData:IHeavyData
    {

        #region IHeavyData Members

        public void LoadData()
        {
            Console.WriteLine(".....Loading heavy data");
        }

        public void DisplayData()
        {
            Console.WriteLine(".....Displaying data");
        }

        #endregion
    }
}
