using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class GoAir:IFlight
    {
        private string _name;
        private ATCMediator _atc;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public GoAir()
        {
            _name = "GoAir";
        }

        public void SetAtc(ATCMediator atc)
        {
            this._atc = atc;
        }

        public void InitiateConversation()
        {
            _atc.RegisterForLanding(this);
        }

        public void AskForLanding()
        {
            _atc.AskPermissionToLand(this);
        }

        public void GetNotified()
        {
            Console.WriteLine("{0} notified by atc to stay away", this.Name);
        }
    }
}
