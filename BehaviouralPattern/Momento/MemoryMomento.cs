using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Momento
{
    public class MemoryMomento
    {
        string _Name;
        string _PhoneNumber;

        internal string Name { get { return _Name; } set { _Name = value; } }
        internal string PhoneNumber { get { return _PhoneNumber; } set { _PhoneNumber = value; } }
    }
}
