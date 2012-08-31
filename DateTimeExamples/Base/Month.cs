using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Base
{
    public class Month<T> where T : class, IFindMonth
    {
        private readonly int _month;
        private readonly int _year;
        private readonly int _day;
        
        public string DayName { get { return new DateTime(_year, _month, _day).DayOfWeek.ToString(); } }
        public int DaysInMonth { get { return DateTime.DaysInMonth(_year, _month); } }

        public Month(int year, int month, int day)
        {
            _year = year;
            _day = day;
            _month = month;
        }
    }
}