using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Command pattern - Behavioural pattern
    /// 
    /// Purpose
    /// (1) Encapsulate a request with associated info & method to be called to execute in a single object called command
    /// (2) Setting up mechanism to serve request & the request can be invoked in any time by the invoker
    /// (3) Separing the command from the functionality implementation (receiver)
    /// 
    /// Here:
    /// Robot - Receiver
    /// Remote controller - Invoker
    /// AbstractCommand, CmdMove - Command objects
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Invoker
            RemoteController controller = new RemoteController();
            //Receiver
            Robot robot = new Robot(0, 0);
            //Command
            AbstractCommand move1 = new CmdMove(robot);
            AbstractCommand move2 = new CmdMove(robot);
            AbstractCommand move3 = new CmdMove(robot);

            Console.WriteLine("-----Orginal state of robot----");
            Console.WriteLine("Angle: {0}, Distance:{1}", robot.Angle, robot.Distance);

            controller._queue.Enqueue(move1);
            controller._queue.Enqueue(move2);
            controller._queue.Enqueue(move3);

            


            Console.WriteLine("-----After moving----");
            controller.Execute();
            Console.WriteLine("Angle: {0}, Distance:{1}", robot.Angle, robot.Distance);

            Console.WriteLine("-----After undoing last----");
            controller.UndoLast();
            Console.WriteLine("Angle: {0}, Distance:{1}", robot.Angle, robot.Distance);


            Console.WriteLine("-----After Undoing----");
            controller.UnDoAll();
            Console.WriteLine("Angle: {0}, Distance:{1}", robot.Angle, robot.Distance);

            Console.ReadKey();

        }
    }
}
