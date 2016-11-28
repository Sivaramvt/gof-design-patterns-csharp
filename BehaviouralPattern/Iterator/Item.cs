using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class Item
    {
        private string _name;
        public string Name { get { return this._name; } set { this._name = value; } }
        public Item(string name) { this._name = name; }
    }
}
