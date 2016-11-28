using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class LowerCase: CaseState
    {
        public override string WriteText(string text)
        {
            return text.ToLower();
        }
    }
}
