using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Base
{
    public class Month<T> where T : class, IFindMonth
    {
        public int Year { get; set; }

        private readonly int _month;
        private readonly int _day;

        public Month() { }
        public Month(int year, int month, int day)
        {
            Year = year;
            _day = day;
            _month = month;
        }

        public string DayName { get { return new DateTime(Year, _month, _day).DayOfWeek.ToString(); } }
    }
}