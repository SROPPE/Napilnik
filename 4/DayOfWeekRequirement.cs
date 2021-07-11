using System;

namespace Homework4
{
    public class DayOfWeekRequirement : ILoggingRequirement
    {
        private readonly DayOfWeek _dayOfWeek;

        public DayOfWeekRequirement(DayOfWeek dayOfWeek)
        {
            _dayOfWeek = dayOfWeek;
        }

        public bool IsDone() =>
            _dayOfWeek == DateTime.Now.DayOfWeek;
    }
}