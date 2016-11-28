using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// Mediator pattern - Behavioural pattern
    /// 
    /// Purpose
    /// (1) Facilitate object communications through a broker (mediator) & avoids direct object to object communication
    /// (2) Facilitate loose coupling between objects
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ATCMediator atc = new ATCMediator();

            IFlight kingfisher = new KingFisher();
            kingfisher.SetAtc(atc);

            IFlight goAir = new GoAir();
            goAir.SetAtc(atc);


            kingfisher.InitiateConversation();
            goAir.InitiateConversation();

            goAir.AskForLanding();

            Console.ReadKey();
        }
    }
}
