using System;
using DateTimeExamples.Types.Months;

namespace DateTimeExamples.Extensions
{
    public static class FebruaryExtensions
    {
        public static int February(this February value, int year)
        {
            return DateTime.DaysInMonth(year, 2);
        }

        public static February February(this int value, int year)
        {
            return new February(year, 2, value);
        }
    }
}