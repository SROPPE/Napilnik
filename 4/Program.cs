using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "Test";
            var fileLoggingPolicy = new FileLoggingPolicy(path);
            var consoleLoggingPolicy = new ConsoleLoggingPolicy();
            var emptyRequirement = new EmptyRequirement();
            var fridayRequirement = new DayOfWeekRequirement(DayOfWeek.Friday);

            var defaultFileLogger = new Logger(fileLoggingPolicy, emptyRequirement);

            var defaultConsoleLogger = new Logger(consoleLoggingPolicy, emptyRequirement);

            var fridayFileLogger = new Logger(fileLoggingPolicy, fridayRequirement);

            var fridayConsoleLogger = new Logger(consoleLoggingPolicy, fridayRequirement);

            var defaultConsoleAndFridayFileLogger = new CombinedLogger(defaultConsoleLogger, fridayFileLogger);

            var pathfinder1 = new Pathfiender(defaultFileLogger);
            pathfinder1.Find();

            var pathfinder2 = new Pathfiender(defaultConsoleLogger);
            pathfinder2.Find();

            var pathfinder3 = new Pathfiender(fridayFileLogger);
            pathfinder3.Find();

            var pathfinder4 = new Pathfiender(fridayConsoleLogger);
            pathfinder4.Find();

            var pathfinder5 = new Pathfiender(defaultConsoleAndFridayFileLogger);
            pathfinder5.Find();
        }
    }
}
