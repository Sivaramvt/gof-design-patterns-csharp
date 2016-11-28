using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class MonthExpression: AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Expression = context.Expression.Replace("MM", DateTime.UtcNow.Month.ToString());

        }
    }
}
