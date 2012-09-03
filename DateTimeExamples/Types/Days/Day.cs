using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Days
{
    public class Day<T> where T : IFindDays
    {
        public static DateTime ThisWeek()
        {
            return DateTime.Today.AddDays(GetDayOfWeekOfT() - DateTime.Today.DayOfWeek);
        }
        public static DateTime NextWeek()
        {
            return ThisWeek().AddDays(7);
        }

        public static DateTime InTwoWeeks()
        {
            return NextWeek().AddDays(7);
        }





        public static DateTime Tomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        public static DateTime Yesterday()
        {
            return DateTime.Today.AddDays(-1);
        }


        static DayOfWeek GetDayOfWeekOfT()
        {
            IFindDays val = Activator.CreateInstance<T>();
            return val.GetDayName();
        }


        //public static int DaysToAdd(DayOfWeek current, DayOfWeek desired)
        //{
        //    int c = (int)current;
        //    int d = (int)desired;
        //    int n = (7 - c + d);
        //    return (n > 7) ? n % 7 : n;
        //}
    }
}