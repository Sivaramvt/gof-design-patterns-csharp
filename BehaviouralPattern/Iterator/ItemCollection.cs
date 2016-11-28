using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Iterator
{
    class ItemCollection : IEnumerable
    {
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }


        #region IEnumerable Members

        System.Collections.IEnumerator  System.Collections.IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                yield return _items[i];

            }
 	        
        }

        #endregion
}
}
