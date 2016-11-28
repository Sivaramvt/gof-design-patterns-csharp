using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    interface IPlatformImplementation
    {
        string Name { get; set; }

        void AssignJob();
    }
}
