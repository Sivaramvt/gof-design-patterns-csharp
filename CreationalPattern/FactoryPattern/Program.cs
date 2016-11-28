using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// Factory pattern avoids
    /// (1) Lot of 'new' keyword in the client
    /// (2) Client doesn't need to be aware of the the concrete implementations (here products)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            IComponent screenComponent = ComponentFactory.GetComponent("Screen");
            IComponent cpuComponent = ComponentFactory.GetComponent("CPU");

            int totalCost = screenComponent.Price() + cpuComponent.Price();

            Console.WriteLine("Total Price:{0}rs", totalCost);

        }
    }
}
