using System;
using DateTimeExamples.Types.Months;

namespace DateTimeExamples.Types
{
    public class DaysInMonth
    {
        public static int Of(January january)
        {
            return DateTime.DaysInMonth(january.Year, 1);
        }

        public static int Of(February february)
        {
            return DateTime.DaysInMonth(february.Year, 2);
        }




        //public static int January(int year)
        //{
        //    return DateTime.DaysInMonth(year, 1);
        //}

    }
}