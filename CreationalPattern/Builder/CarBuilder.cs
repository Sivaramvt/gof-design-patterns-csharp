using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class CarBuilder:AbstractVehicleBuilder
    {
        IVehicle car;

        public CarBuilder(){car = new Car();}

        public override IVehicle GetProduct(){return car;}
        public override void GetParts() { Console.WriteLine("Getting parts for car.."); }
        public override void AssembleParts() { Console.WriteLine("Assembling parts for car.."); }
        public override void FitWheels() { Console.WriteLine("Fitting wheels in car.."); }
        public override void Test() { Console.WriteLine("Testing car.."); }  
    }
}
