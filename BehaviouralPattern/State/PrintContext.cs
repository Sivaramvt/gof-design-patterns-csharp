using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class PrintContext
    {
        CaseState _state;
        bool _IsUpperON;

        public PrintContext()
        {            
            _IsUpperON = true;
        }

        public void PrintText(string text)
        {
            if (_IsUpperON)
            {
                _state = new UpperCase();
                _IsUpperON = false;
            }
            else
            {
                _state = new LowerCase();
                _IsUpperON = true;
            }
            
            Console.WriteLine(_state.WriteText(text));

        }
    }
}
