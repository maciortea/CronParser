using System;

namespace CronParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length != CronInterpreter.CommandPartsCount)
            {
                Console.WriteLine("Invalid command parameters.");
                return;
            }

            try
            {
                var cronInterpreter = new CronInterpreter();
                CronResult cronResult = cronInterpreter.Interpret(args);

                var cronPrinter = new CronPrinter();
                cronPrinter.PrintToConsole(cronResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
