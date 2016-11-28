using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    /// <summary>
    /// Facade - structural pattern
    /// 
    /// Purpose
    /// (1) Provide an easy to access interface to subsystem functionalities to client client
    /// (2) Hides implementation details
    /// 
    /// Scenario:
    ///  Computer is a facade & users will operate only on computer for starting / stopping.
    ///  Computer internally uses mem, hdd, processor to do the job.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade facade = new ComputerFacade(new Processor(), new HDD(), new Memory());
            facade.Start();
            facade.ExecuteProgram();

            Console.ReadKey();
        }
    }
}
