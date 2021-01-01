using CronParser.Expressions;
using CronParser.Expressions.Recurrence;
using System.Collections.Generic;

namespace CronParser
{
    public class CronInterpreter
    {
        public const int CommandPartsCount = 6;

        public CronResult Interpret(string[] args)
        {
            var expressions = new List<ExpressionCore>
            {
                new MinuteExpression(),
                new HourExpression(),
                new DayExpression(),
                new MonthExpression(),
                new DayOfWeekExpression(),
            };

            var expressionResults = new List<CronExpressionResult>();

            for (int i = 0; i < CommandPartsCount - 1; i++)
            {
                int[] values = expressions[i].Interpret(new Context(args[i]));
                var expressionResult = new CronExpressionResult(expressions[i].Name, values);
                expressionResults.Add(expressionResult);
            }

            return new CronResult(expressionResults, args[CommandPartsCount - 1]);
        }
    }
}
