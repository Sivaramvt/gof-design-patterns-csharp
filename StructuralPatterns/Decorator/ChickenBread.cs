using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class ChickenBread:OrderDecorator
    {
        public ChickenBread(IOrder bread):base(bread)
        {
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("Preparing Chicken...");
            
        }

        public override int GetPrice()
        {
            return 20 + base.GetPrice();
        }
    }
}
