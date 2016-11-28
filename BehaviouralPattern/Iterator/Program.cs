using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// Iterator - Behavioural pattern
    /// Purpose:
    /// (1) Allows sequential access to a collection of objects
    /// 
    /// C# has inbuilt support for it
    /// IEnumerable interace faciltates it
    /// Iterators are called enumerators in C#
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("Item 1");
            Item item2 = new Item("Item 2");
            Item item3 = new Item("Item 3");
            Item item4 = new Item("Item 4");
            Item item5 = new Item("Item 5");

            ItemCollection collection = new ItemCollection();
            collection.AddItem(item1);
            collection.AddItem(item2);
            collection.AddItem(item3);
            collection.AddItem(item4);
            collection.AddItem(item5);

            foreach (Item item in collection)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();

        }
    }
}
