using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class OrderDecorator:IOrder
    {
        protected IOrder _breadOrder;

        public OrderDecorator(IOrder breadOrder)
        {
            _breadOrder = breadOrder;
        }

        #region IOrder Members

        public virtual void Prepare()
        {
            _breadOrder.Prepare();
        }

        public virtual int GetPrice()
        {
            return _breadOrder.GetPrice();
        }

        #endregion
    }
}
