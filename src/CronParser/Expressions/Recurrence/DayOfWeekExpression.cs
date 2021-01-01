using System.Linq;

namespace CronParser.Expressions.Recurrence
{
    public class DayOfWeekExpression : ExpressionCore
    {
        public DayOfWeekExpression() : base("Day of week")
        {
        }

        public override int[] GetPossibleValues()
        {
            return Enumerable.Range(1, 7).ToArray();
        }
    }
}
