using System.Linq;

namespace CronParser.Expressions.Recurrence
{
    public class MonthExpression : ExpressionCore
    {
        public MonthExpression() : base("Month")
        {
        }

        public override int[] GetPossibleValues()
        {
            return Enumerable.Range(1, 12).ToArray();
        }
    }
}
