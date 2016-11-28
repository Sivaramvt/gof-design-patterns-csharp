using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyInitialization
{
    class MemoryHeavyStuff
    {
        private string _reourceName;

        public string ResourceName { get { return _reourceName; } }

        public MemoryHeavyStuff(string name)
        {
            this._reourceName = name;
        }
       
    }
}
