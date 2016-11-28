using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public abstract class AbstractCommand
    {
        protected Robot _robot;

        public AbstractCommand(Robot robot)
        {
            this._robot = robot;
        }

        public abstract void Execute();
        public abstract void ReverseExecute();        

    }
}
