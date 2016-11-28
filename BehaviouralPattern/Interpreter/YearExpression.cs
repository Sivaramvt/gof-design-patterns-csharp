using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class YearExpression:AbstractExpression
    {

        public override void Interpret(Context context)
        {
            context.Expression = context.Expression.Replace("YYYY", DateTime.UtcNow.Year.ToString());
            
        }
    }
}
