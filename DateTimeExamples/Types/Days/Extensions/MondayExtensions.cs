using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Days.Extensions
{
    public static class DayExtensions
    {
        public static IFindDays Week(this DayOfWeek value)
        {
            IFindDays result = null;
            switch (value)
            {
                case DayOfWeek.Sunday:
                    result = 
                    break;
                case DayOfWeek.Monday:
                    today = today.AddDays(-0);
                    break;
                case DayOfWeek.Tuesday:
                    today = today.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    today = today.AddDays(-2);
                    break;
                case DayOfWeek.Thursday:
                    today = today.AddDays(-3);
                    break;
                case DayOfWeek.Friday:
                    today = today.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    today = today.AddDays(-5);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return today;
        }
    }
}