using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    interface INode
    {
        string Name { get; set; }        
        void Add(object o);


    }
}
