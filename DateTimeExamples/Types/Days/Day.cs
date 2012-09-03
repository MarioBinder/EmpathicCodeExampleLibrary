using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Days
{
    public class Day<T> where T : IFindDays
    {
        public static DayOfWeek This()
        {
            return DateTime.Today.DayOfWeek;
        }
        public static DateTime Next()
        {
            return DateTime.Today.AddDays(7);
        }

        public static DateTime Tomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        public static DateTime Yesterday()
        {
            return DateTime.Today.AddDays(-1);
        }
    }
}