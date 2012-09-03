using System;
using DateTimeExamples.Contracts;
using DateTimeExamples.Types.Months;

namespace DateTimeExamples.Types
{
    public class DaysInMonth
    {
        public static int Of(IFindMonths month)
        {
            return DateTime.DaysInMonth(month.Year, month.Month);
        }
    }
}