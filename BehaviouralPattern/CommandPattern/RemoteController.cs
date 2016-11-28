using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class RemoteController
    {
        private Stack<AbstractCommand> _stack;
        public  Queue<AbstractCommand> _queue;

        public RemoteController()
        {
            _stack = new Stack<AbstractCommand>();
            _queue = new Queue<AbstractCommand>();
        }

        public void Execute()
        {
            while (_queue.Count > 0)
            {
                AbstractCommand cmd = _queue.Dequeue();
                cmd.Execute();
                _stack.Push(cmd);
            }
        }

        public void UnDoAll()
        {
            while (_stack.Count > 0)
            {
                AbstractCommand cmd = _stack.Pop();
                cmd.ReverseExecute();
            }
        }

        public void UndoLast()
        {
            AbstractCommand cmd = _stack.Pop();
            cmd.ReverseExecute();
        }
    }
}
