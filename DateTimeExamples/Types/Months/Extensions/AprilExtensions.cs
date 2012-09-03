namespace DateTimeExamples.Types.Months.Extensions
{
    public static class AprilExtensions
    {
        public static April April(this int value, int year)
        {
            return new April(year, 4, value);
        }
    }
}