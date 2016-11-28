using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class CmdMove:AbstractCommand
    {
        public CmdMove(Robot r):base(r){}

        public override void Execute()
        {
            _robot.MoveForward(10);
        }

        public override void ReverseExecute()
        {
            _robot.MoveBackward(10);
        }
    }
}
