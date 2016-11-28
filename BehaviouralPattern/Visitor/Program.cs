using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    /// <summary>
    /// Visitor - Behavioral pattern
    /// 
    /// Purpose:
    /// (1) Adding functionality to a datastructure without modifying it. New visitor can be added to introduce new functionality without modifying the class
    /// 
    /// Roles:
    /// (1) Visitor which exposes a visit method which will be called by the datastructure
    /// (2) Datastructure which must have an accept method where it passes it's reference
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Siva");
            customer1.accept(new PrintVisitor());

            Console.ReadKey();

        }
    }
}
