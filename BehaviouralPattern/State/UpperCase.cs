using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class UpperCase:CaseState
    {

        public override string WriteText(string text)
        {
            return text.ToUpper();
        }
    }
}
