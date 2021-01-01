using System.Collections.Generic;

namespace CronParser
{
    public class CronResult
    {
        public IReadOnlyList<CronExpressionResult> ExpressionResults { get; }
        public string Command { get; }

        public CronResult(List<CronExpressionResult> expressionResults, string command)
        {
            ExpressionResults = expressionResults;
            Command = command;
        }
    }
}
