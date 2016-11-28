using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class MotorCycle:IVehicle
    {
        private int cc;

        public int CC
        {
            get { return cc; }
            set { cc = value; }
        }
        #region IVehicle Members

        public void ShowSpecifications()
        {
            Console.WriteLine("Motorcycle---");
        }

        #endregion
    }
}
