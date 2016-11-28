using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class BroadbandCustomerMeet : ICloneable
    {
        private List<IBroadbandCustomer> _particpants;
        public List<IBroadbandCustomer> Participants { get { return _particpants; } set { _particpants = value; } }

        private string _location;
        public string Location { get { return _location; } set { _location = value; } }


       public BroadbandCustomerMeet()
        {
            _particpants = new List<IBroadbandCustomer>();

            IBroadbandCustomer airtelCustomer = new AirtelCustomer();
            airtelCustomer.Name = "Airtel guy";

            IBroadbandCustomer vodafoneCustomer = new VodafoneCustomer();
            vodafoneCustomer.Name = "Vodaone guy";

            _particpants.Add(airtelCustomer);
            _particpants.Add(vodafoneCustomer);
        }

        #region ICloneable Members

        //Shallow copy
       public object Clone()
        {
            return this.MemberwiseClone();
        }

        //Deep copy
      /*  public object Clone()
        {
            BroadbandCustomerMeet newCust = (BroadbandCustomerMeet)this.MemberwiseClone();
            newCust.Participants = new List<IBroadbandCustomer>();
            foreach (IBroadbandCustomer cust in this.Participants)
            {
                newCust.Participants.Add((IBroadbandCustomer)cust.Clone()); 
            }
            return newCust;
        }*/

        #endregion
    }
}
