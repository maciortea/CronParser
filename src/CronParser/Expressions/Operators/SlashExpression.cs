using System.Linq;

namespace CronParser.Expressions.Operators
{
    public class SlashExpression : Expression
    {
        private readonly Expression _leftExpression;
        private readonly Expression _rightExpression;

        public SlashExpression(Expression leftExpression, Expression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public override int[] Interpret(Context context)
        {
            int[] values = _leftExpression.Interpret(context);
            int divideBy = _rightExpression.Interpret(context)[0];
            return values.Where(v => v % divideBy == 0).ToArray();
        }
    }
}
