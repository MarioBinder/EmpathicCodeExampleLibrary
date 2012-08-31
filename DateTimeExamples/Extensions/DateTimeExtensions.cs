using DateTimeExamples.Base;
using DateTimeExamples.Types;

namespace DateTimeExamples.Extensions
{
    public static class DateTimeExtensions
    {
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
    }
}