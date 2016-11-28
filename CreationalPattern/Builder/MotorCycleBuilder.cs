using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class MotorCycleBuilder:AbstractVehicleBuilder
    {
        IVehicle motorCycle;

        public MotorCycleBuilder() { motorCycle = new MotorCycle(); }

        public override IVehicle GetProduct() { return motorCycle; }
        public override void GetParts() { Console.WriteLine("Getting parts for MotorCycle.."); }
        public override void AssembleParts() { Console.WriteLine("Assembling parts for MotorCycle.."); }
        public override void FitWheels() { Console.WriteLine("Fitting wheels in MotorCycle.."); }
        public override void Test() { Console.WriteLine("Testing MotorCycle.."); }  
    }
}
