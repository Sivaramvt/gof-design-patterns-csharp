using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Momento
{
    public class MomentoCareTaker
    {
        private MemoryMomento _Momento;

        internal void SetMomento(MemoryMomento momento)
        {
            _Momento = momento;
        }

        internal MemoryMomento GetMomento()
        {
            return _Momento;
        }

    }
}
