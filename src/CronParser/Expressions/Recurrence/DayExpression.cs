using System.Linq;

namespace CronParser.Expressions.Recurrence
{
    public class DayExpression : ExpressionCore
    {
        public DayExpression() : base("Day of month")
        {
        }

        public override int[] GetPossibleValues()
        {
            return Enumerable.Range(1, 31).ToArray();
        }
    }
}
