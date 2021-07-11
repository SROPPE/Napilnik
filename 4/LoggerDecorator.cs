using System;

namespace Homework4
{
    public abstract class LoggerDecorator : ILogger
    {
        protected readonly ILogger _decoratableLogger;

        public LoggerDecorator(ILogger decporatable)
        {
            _decoratableLogger = decporatable ?? throw new ArgumentNullException(nameof(decporatable));
        }

        public abstract void Write(string message);
    }
}