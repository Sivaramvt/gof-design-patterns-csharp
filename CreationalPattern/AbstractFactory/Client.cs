using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract factory hides the concrete factories and concrete products from the client.
    /// Simimar to factory but provides one more level of abstraction
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            AbstractComputerFactory computerFactory = AbstractComputerFactory.GetFactory("component");
            IProduct cpu = computerFactory.GetProduct("cpu");
            IProduct mouse = computerFactory.GetProduct("mouse");

            computerFactory = AbstractComputerFactory.GetFactory("wire");
            IProduct USBWire = computerFactory.GetProduct("usb");
            IProduct powerCord = computerFactory.GetProduct("powercord");

            int totalWeight = cpu.GetWeight() + mouse.GetWeight() + USBWire.GetWeight() + powerCord.GetWeight();
            Console.WriteLine("Total weight: {0} g", totalWeight);

            Console.ReadKey();
        }
    }
}
