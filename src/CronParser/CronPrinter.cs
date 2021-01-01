using System;

namespace CronParser
{
    public class CronPrinter
    {
        private const int NamePadding = 14;

        public void PrintToConsole(CronResult cronResult)
        {
            foreach (var expressionResult in cronResult.ExpressionResults)
            {
                Console.Write($"{expressionResult.ExpressionName, -NamePadding} ");
                foreach (int value in expressionResult.Values)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"{"Command", -NamePadding} {cronResult.Command}");
        }
    }
}
