using System;

namespace DateTimeExamples.Contracts
{
    public interface IFindMonth
    {
        int Year { get; set; }
        int Month { get; }
        string DayName { get; }
    }
}