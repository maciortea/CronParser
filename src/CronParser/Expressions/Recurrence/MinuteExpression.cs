using System.Linq;

namespace CronParser.Expressions.Recurrence
{
    public class MinuteExpression : ExpressionCore
    {
        public MinuteExpression() : base("Minute")
        {
        }

        public override int[] GetPossibleValues()
        {
            return Enumerable.Range(0, 60).ToArray();
        }
    }
}
