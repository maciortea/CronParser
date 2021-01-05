using System.Collections.Generic;

namespace CronParser.Expressions.Operators
{
    public class CommaExpression : Expression
    {
        private IEnumerable<Expression> _expressions;

        public CommaExpression(IEnumerable<Expression> expressions)
        {
            _expressions = expressions;
        }

        public override int[] Interpret(Context context)
        {
            var values = new List<int>();
            foreach (Expression expression in _expressions)
            {
                values.AddRange(expression.Interpret(context));
            }
            return values.ToArray();
        }
    }
}
