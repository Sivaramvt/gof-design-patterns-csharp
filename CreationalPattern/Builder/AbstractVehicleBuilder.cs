using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract  class AbstractVehicleBuilder
    {
        public abstract IVehicle GetProduct();
        public abstract void GetParts();
        public abstract void AssembleParts();
        public abstract void FitWheels();
        public abstract void Test();    

    }
}
