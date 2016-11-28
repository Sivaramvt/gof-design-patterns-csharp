using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// Singleton - Creational pattern
    /// Purpose:
    /// (1) Only one object available in an app
    /// 
    /// Variant: Multiton which maintains a map of singleton objects in an application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:{0}", ErrorHandler.Instance.Name);
            ErrorHandler.Instance.LogError("First error");
            ErrorHandler.Instance.LogError("Second error");

            Console.ReadKey();
        }
    }
}
