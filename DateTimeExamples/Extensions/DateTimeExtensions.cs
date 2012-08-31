using System;
using DateTimeExamples.Types.Months;

namespace DateTimeExamples.Extensions
{
    public static class DateTimeExtensions
    {
        public static int January(this January value, int year)
        {
            return DateTime.DaysInMonth(year, 1);
        }
        public static int February(this February value, int year)
        {
            return DateTime.DaysInMonth(year, 2);
        }






        public static January January(this int value, int year)
        {
            return new January(year, 1, value);
        }

        public static February February(this int value, int year)
        {
            return new February(year, 2, value);
        }

        public static March March(this int value, int year)
        {
            return new March(year, 3, value);
        }

        public static April April(this int value, int year)
        {
            return new April(year, 4, value);
        }

        public static int DaysInMonth(this int value)
        {
            return 1;
        }
    }
}