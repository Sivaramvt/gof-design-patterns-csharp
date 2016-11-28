using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adaptee - No access to source code; Cannot modify
    /// </summary>
    class AdapteeStack
    {
        private Stack<string> _stack = new Stack<string>();

        public void Push(string str)
        {
            _stack.Push(str);
        }

        public int Count()
        {
            return _stack.Count;
        }
    }
}
