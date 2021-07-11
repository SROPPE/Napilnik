using System;

namespace Homework4
{
    public class CombinedLogger : LoggerDecorator
    {
        private readonly ILogger _additionalLogger;

        public CombinedLogger(ILogger additional, ILogger decoratable) : base(decoratable)
        {
            _additionalLogger = additional ?? throw new ArgumentNullException(nameof(additional));
        }

        public override void Write(string message)
        {
            _additionalLogger.Write(message);
            _decoratableLogger.Write(message);
        }
    }
}