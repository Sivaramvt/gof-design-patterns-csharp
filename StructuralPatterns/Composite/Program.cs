using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    /// <summary>
    /// Composite pattern - Structural pattern
    /// 
    /// Purpose:
    /// (1) If there is tree kind of structure where leaf & composite nodes are present and both of want to be treated uniformally
    /// you can use composite pattern.
    /// 
    /// Scenario:
    /// (1) Customer(1)--->Address(1...*) ----> PhoneNos(1...*)
    /// 
    /// Explanation:
    /// All 3 classes are treated uniformally & there can be a INode interface which is implemented by all 3.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Name = "Siva";

            Address address = new Address();
            address.Name = "3rd street";

            PhoneNos phone = new PhoneNos();
            phone.Name = "9741325280";

            PhoneNos phone1 = new PhoneNos();
            phone1.Name = "9986851087";

            cust.Add(address);
            address.Add(phone);
            address.Add(phone1);

            Console.WriteLine(cust.Name + ",");
            foreach (Address ad in cust.connectedNode)
            {
                Console.WriteLine(ad.Name + ",");
                foreach(PhoneNos ph in ad.connectedNode)
                {
                    Console.WriteLine("Phone: " + ph.Name );
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }

        
    }
}
