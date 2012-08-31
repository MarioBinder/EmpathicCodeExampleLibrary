﻿using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types
{
    public class April : Month<April>, IFindMonth
    {
        public April(int year, int month, int day)
            : base(year,month, day)
        {
            if (day >= 31) throw new AprilComplaint();
        }
    }
}