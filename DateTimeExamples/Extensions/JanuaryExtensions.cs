using System;
using DateTimeExamples.Types.Months;

namespace DateTimeExamples.Extensions
{
    public static class JanuaryExtensions
    {
        public static int January(this January value, int year)
        {
            return DateTime.DaysInMonth(year, 1);
        }
        public static January January(this int value, int year)
        {
            return new January(year, 1, value);
        }
    }
}