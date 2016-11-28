using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public interface IVehicle
    {
        int CC{get;set;}
        void ShowSpecifications();
    }
}
