using System;

namespace Homework4
{
    public class ConsoleLoggingPolicy : ILoggingPolicy
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}