using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Base
{
    public class Month<T> where T : class, IFindMonth
    {
        public int _Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }

        public string DayName { get { return new DateTime(Year, _Month, Day).DayOfWeek.ToString(); } }
        public int DaysInMonth { get { return DateTime.DaysInMonth(Year, _Month); } }

        public Month(int year, int day)
        {
            Year = year;
            Day = day;
        }
    }
}