using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyInitialization

{
    /// <summary>
    /// Delays the initialization of class till it's been used. It can be used to defer the loading of resource inten
    /// C# 4.0 provdes a class to facilitate this
    /// </summary>
   class Program
    {
        static void Main(string[] args)
        {
            Lazy<MemoryHeavyStuff> memHeavyObject = new Lazy<MemoryHeavyStuff>(() => { return new MemoryHeavyStuff("Heavy resource yaar"); });
            if (!memHeavyObject.IsValueCreated) { Console.WriteLine("Not yet created dude!"); }
            Console.WriteLine((memHeavyObject.Value as MemoryHeavyStuff).ResourceName);
            Console.ReadKey();
        }
    }
}
