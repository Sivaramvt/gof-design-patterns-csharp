using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Construction process
    /// </summary>
    public class Director
    {
        public static IVehicle BuildVehicle(AbstractVehicleBuilder builder)
        {
            builder.GetParts();
            builder.AssembleParts();
            builder.FitWheels();
            builder.Test();
            return builder.GetProduct();
        }
    }
}
