﻿using System;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Days
{
    public class Monday : Day<Monday>, IFindDays
    {
        public DayOfWeek GetDayName()
        {
            return DayOfWeek.Monday;
        }
    }
}