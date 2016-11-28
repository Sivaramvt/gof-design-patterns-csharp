using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightObject
{
    /// <summary>
    /// Flyweight - Structural pattern
    /// 
    /// Purpose:
    /// (1) Sharing common data of similar objects into a separate data structure to save the memory
    /// 
    /// Example:
    /// Document processor - What if we have to store all the formatting info like font properties along with the character? Memory bloat.
    /// This is best avoided by having formatting info in separate object.    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Hello World");

            foreach (Character c in document.characters)
            {
                Console.WriteLine(c.getCharacterColor());
            }

            Console.ReadKey();
        }
    }
}
