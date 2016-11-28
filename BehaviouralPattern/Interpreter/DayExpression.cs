using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class DayExpression:AbstractExpression
    {

        public override void Interpret(Context context)
        {
            context.Expression = context.Expression.Replace("DD", DateTime.UtcNow.Day.ToString());
            
        }
    }
}
