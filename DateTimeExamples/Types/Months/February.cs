using System;
using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Months
{
    public class February : Month<February>, IFindMonth
    {
        public int Month { get { return 2; } }

        public static February In(int year)
        {
            return new February(year);
        }

        public February(int year)
        {
            Year = year;
        }

        public February(int year, int month, int day)
            : base(year, month, day)
        {
            if ((DateTime.IsLeapYear(year) && day >= 29) || day > 28) throw new FebruaryComplaint();
        }
    }
}