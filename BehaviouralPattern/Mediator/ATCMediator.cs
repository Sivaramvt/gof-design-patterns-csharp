using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class ATCMediator
    {
        private List<IFlight> landingFlights = new List<IFlight>();

        public void RegisterForLanding(IFlight flight)
        {
            landingFlights.Add(flight);
            Console.WriteLine("Registering flight for landing: {0}", flight.Name);
        }

        public void AskPermissionToLand(IFlight flight)
        {
            Console.WriteLine("Granting permission to land: {0}", flight.Name);

            foreach (IFlight flt in landingFlights)
            {
                if (flt.Name != flight.Name)
                    flt.GetNotified();
            }
        }
        
    }
}
