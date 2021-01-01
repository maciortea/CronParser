using System.Linq;

namespace CronParser.Expressions.Recurrence
{
    public class HourExpression : ExpressionCore
    {
        public HourExpression() : base("Hour")
        {
        }

        public override int[] GetPossibleValues()
        {
            return Enumerable.Range(0, 24).ToArray();
        }
    }
}
