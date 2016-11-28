using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// Decorator pattern - Structural design pattern
    /// 
    /// Purpose:
    /// (1) Adding behaviour to an object at run time (with consideration in design time)
    /// (2) Alternate to inheritance for extending functionality
    /// 
    /// Scenario:
    /// Order taking in restaurant
    /// Basic menu is bread
    /// There can be toppings like chicken, drink
    /// With every topping price goes up.
    /// 
    /// Basic order is the orignal object
    /// Toppings are introduced through decorator object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IOrder order =  new ChickenBread(new BreadOrder());
            order.Prepare();
            Console.WriteLine(order.GetPrice());

            Console.ReadKey();

        }
    }
}
