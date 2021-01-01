using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CronParser.Expressions.Operators
{
    public class RangeExpression : Expression
    {
        private readonly Expression _startExpression;
        private readonly Expression _endExpression;

        public RangeExpression(Expression startExpression, Expression endExpression)
        {
            _startExpression = startExpression;
            _endExpression = endExpression;
        }

        public override int[] Interpret(Context context)
        {
            int start = _startExpression.Interpret(context)[0];
            int end = _endExpression.Interpret(context)[0];
            int count = end - start + 1;
            return Enumerable.Range(start, count).ToArray();
        }
    }
}
