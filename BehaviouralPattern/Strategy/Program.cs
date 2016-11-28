using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// Strategy pattern - behavioural pattern (similar to state pattern)
    /// 
    /// Purpose:
    /// (1) Way to encapsulate different algorithms
    /// (2) Decide which algorithm to use at runtime
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context cntx = new Context();
            cntx.SetStrategy(new AdditionStrategy());
            Console.WriteLine(cntx.calculate(10, 5));

            cntx.SetStrategy(new SubtractionStrategy());
            Console.WriteLine(cntx.calculate(10, 5));

            Console.ReadKey();
        }
    }
}
