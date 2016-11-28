using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// Prototype pattern - Object creational pattern
    /// It is about creating copy of an object 
    /// Copy - 2 types
    /// (1) Shallow copy
    /// (2) Deep copy
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            BroadbandCustomerMeet chennaiMeet = new BroadbandCustomerMeet();
            chennaiMeet.Location = "Chennai";

            BroadbandCustomerMeet delhiMeet = (BroadbandCustomerMeet)chennaiMeet.Clone();
            delhiMeet.Location = "Delhi";

            Console.WriteLine("-----------------Shallow copy-------------------------");
            //This won't change & shows that it is a copy. Change in the copy doesn't get reflected here
            Console.WriteLine("Chennai meet location: {0}", chennaiMeet.Location);
            Console.WriteLine("Delhi meet location: {0}", delhiMeet.Location);

            //Change in participants of delhi gets reflected in chennai - Coz of shallow copy
            //IN case of deep copy, you get diferent result.
            //Switch is in clone method of BroadbandCustomerMeet
            delhiMeet.Participants[0].Name = "Idea guy";
            foreach (IBroadbandCustomer cust in chennaiMeet.Participants)
            {
                Console.WriteLine("Chennai particpant: {0}", cust.Name);
            }
            Console.ReadKey();

        }
    }
}
