using DateTimeExamples.Types.Months;

namespace DateTimeExamples.Extensions
{
    public static class MarchExtensions
    {
        public static March March(this int value, int year)
        {
            return new March(year, 3, value);
        }
    }
}