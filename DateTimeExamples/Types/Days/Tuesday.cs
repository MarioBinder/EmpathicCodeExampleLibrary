using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Days
{
    public class Tuesday : Day<Tuesday>, IFindDays
    {
        public DayOfWeek GetDayName()
        {
            return DayOfWeek.Tuesday;
        }
    }
}