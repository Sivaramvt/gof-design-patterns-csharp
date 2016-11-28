using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class Context
    {
        private string _expression;

        public string Expression { get { return _expression; } set { _expression = value; } }

        public Context(String data)
        {
            this._expression = data;
        }        
    }
}
