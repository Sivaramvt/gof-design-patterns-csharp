using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    interface IFlight
    {
        string Name { get; set; }

        void SetAtc(ATCMediator atc);
        void InitiateConversation();
        void AskForLanding();
        void GetNotified();

    }
}
