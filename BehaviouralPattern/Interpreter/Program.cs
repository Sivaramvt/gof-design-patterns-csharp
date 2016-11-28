using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    /// <summary>
    /// Pattern for implementing a grammar
    /// Suited for scripting languages / becomes cumbersome for huge grammars
    /// New class created for every token
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(Console.ReadLine());

            string[] tokens = context.Expression.Split(' ');

            List<AbstractExpression> interpreters = new List<AbstractExpression>();

            foreach (string token in tokens)
            {
                switch (token)
                {
                    case "DD":
                        interpreters.Add(new DayExpression());
                        break;

                    case "MM":
                        interpreters.Add(new MonthExpression());
                        break;

                    case "YYYY":
                        interpreters.Add(new YearExpression());
                        break;

                    default:
                        Console.WriteLine("Oops..Some problem dude!");
                        break;
                }
            }

            interpreters.Add(new SpaceExpression());

            foreach (AbstractExpression expn in interpreters)
            {
                expn.Interpret(context);
            }

            Console.WriteLine("Output: {0}", context.Expression);
            Console.ReadKey();
            
        }
    }
}
