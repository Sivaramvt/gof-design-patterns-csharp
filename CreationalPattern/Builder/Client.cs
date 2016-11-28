using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Builder
{
    /// <summary>
    /// Builder pattern - Creational pattern
    /// Primary purpose:
    /// (1) Separte construction from representation
    /// (2) Single construction process can produce multiple representation
    /// 
    /// Construction process - director
    /// Representation - Builder 
    /// 
    /// In this case:
    /// Car, Motorcycle - products
    /// Multiple products out of same construction process.
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            AbstractVehicleBuilder carBuilder = new CarBuilder();
            IVehicle car = Director.BuildVehicle(carBuilder);
            car.ShowSpecifications();
            Console.WriteLine(car.CC);


            AbstractVehicleBuilder motorCycleBuilder = new MotorCycleBuilder();
            IVehicle motorCycle = Director.BuildVehicle(motorCycleBuilder);
            motorCycle.ShowSpecifications();

            Console.ReadKey();
        }
    }
}
