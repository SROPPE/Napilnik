using System;

namespace Homework4
{
    public class Pathfiender
    {
        private readonly ILogger _logger;

        public Pathfiender(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void Find()
        {
            _logger.Write(DateTime.Now.ToString() + "\n");
        }
    }
}
