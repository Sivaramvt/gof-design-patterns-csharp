using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
     class HeavyDataProxy:IHeavyData
    {
        HeavyData _heavyData;

        public HeavyDataProxy()
        {
            _heavyData = new HeavyData();
        }

      

        public void LoadData()
        {
            _heavyData.LoadData();
        }

        public void DisplayData()
        {
            _heavyData.DisplayData();
        }

       


    }
}
