using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    /// <summary>
    /// State pattern - behavioural design pattern
    /// 
    /// Purpose
    /// (1) Changes the behaviour depending on the internal state
    /// 
    /// How it works?
    /// (1) Context - (a)decides and maintains the concrete state (b) Provides easy interface to client
    /// (2) Abstract state
    /// (3) Concrete state
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PrintContext cntx = new PrintContext();
            cntx.PrintText("monday");
            cntx.PrintText("tuesday");
            cntx.PrintText("wednesday");
            cntx.PrintText("thursday");
            cntx.PrintText("friday");
            cntx.PrintText("saturday");
            cntx.PrintText("sunday");

            Console.ReadKey();
        }
    }
}
