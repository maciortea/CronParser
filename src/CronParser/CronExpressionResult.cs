using System.Collections.Generic;

namespace CronParser
{
    public class CronExpressionResult
    {
        public string ExpressionName { get; }
        public IReadOnlyList<int> Values { get; }

        public CronExpressionResult(string expressionName, int[] values)
        {
            ExpressionName = expressionName;
            Values = values;
        }
    }
}
