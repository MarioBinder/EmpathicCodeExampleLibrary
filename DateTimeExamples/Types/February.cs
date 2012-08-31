using System;
using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types
{
    public class February : Month<February>, IFindMonth
    {
        public February(int year, int day)
            : base(year, day)
        {
            if ((DateTime.IsLeapYear(year) && day >= 29) || day > 28) throw new FebruaryComplaint();
            _Month = 2;
        }
    }
}