using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    /// <summary>
    /// Proxy pattern - Structural pattern
    /// 
    /// Purpose:
    /// (1) Creating an lightweight interface for easy consumption to client.
    /// (2) Sometimes, it would save the computation or network bandwidth.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            HeavyDataProxy proxy = new HeavyDataProxy();

            proxy.LoadData();

            //Loading heavy data can be avoided on consequent calls if proxy is employed.
            proxy.LoadData(); proxy.LoadData(); proxy.LoadData();

            Console.ReadKey();

        }
    }
}
