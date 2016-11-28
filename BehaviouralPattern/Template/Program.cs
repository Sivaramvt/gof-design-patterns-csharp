using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    /// <summary>
    /// Behavioural pattern
    /// 
    /// Purpose:
    /// (1) Basic template of the process is already defined
    /// (2) Subclasses given the flexibility to change the behaviour of internal steps in the process
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            ETL etl = new StructuredDataETL();
            etl.Execute();

            Console.ReadKey();
        }
    }
}
