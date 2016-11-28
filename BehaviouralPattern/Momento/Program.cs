using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Momento
{
 
    /// <summary>
    /// Momento pattern - Behavioral pattern
    /// Puprose
    /// (1) Take a backup of internal state of an object without violating encapsualtion, so that the object can restore its state
    /// 
    /// Participants
    /// (1) Orginator - Class for which internal state has to be saved
    /// (2) Momento - Class which saves the state of the orginator. Has data fields like Originator
    /// (3) Caretaker - Takes care of maintaining Momento
    /// 
    /// Dependencies
    /// Originator --->(Week dependency) Momento
    /// Caretaker -->(Aggregator) Momento
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOriginator orginator = new CustomerOriginator();
            orginator.Name = "Siva";
            orginator.PhoneNumber = "97413262";

            

            MomentoCareTaker careTaker = new MomentoCareTaker();
            careTaker.SetMomento(orginator.SaveMomento());

            orginator.Name = "Changed";

            orginator.Restore(careTaker.GetMomento());

            Console.WriteLine(orginator.Name);

            Console.ReadKey();
        }
    }
}
