using System;
using DateTimeExamples.Contracts;
using DateTimeExamples.Types.Months;

namespace DateTimeExamples.Types
{
    public class DaysInMonth
    {
        public static int Of(IFindMonth month)
        {
            return DateTime.DaysInMonth(month.Year, month.Month);
        }
    }
}