using System;

namespace Homework4
{
    public class Logger : ILogger
    {
        private readonly ILoggingPolicy _logginigPolicy;
        private readonly ILoggingRequirement _loggingRequirement;

        public Logger(ILoggingPolicy loggingPolicy, ILoggingRequirement loggingRequirement)
        {
            _logginigPolicy = loggingPolicy ?? throw new ArgumentNullException(nameof(loggingPolicy));
            _loggingRequirement = loggingRequirement ?? throw new ArgumentNullException(nameof(loggingRequirement));
        }

        public void Write(string message)
        {
            if (_loggingRequirement.IsDone())
            {
                _logginigPolicy.Write(message);
            }
        }
    }
}