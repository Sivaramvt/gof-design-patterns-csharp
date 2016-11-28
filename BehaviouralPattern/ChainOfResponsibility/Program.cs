using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Chain of responsibility - Beahavioural pattern
    /// 
    /// Purpose:
    /// (1) Set of objects chained to handle request. Each object can handle a part of the request or choose to skip it.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ExtractProcess eETL = new ExtractProcess();
            TransferProcess tETL = new TransferProcess();
            LoadProcess lETL = new LoadProcess();

            eETL.SetNextProcess(tETL);
            tETL.SetNextProcess(lETL);

            eETL.Process();

            Console.ReadKey();
        }
    }
}
