using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Months
{
    public class January : Month<January>, IFindMonth
    {
        public int Year { get; set; }
        public int Month { get; set; }
        
        public static January In(int year)
        {
            return new January(year, 1);
        }

        public January(int year, int month)
        {
            Year = year;
            Month = month;
        }
        public January(int year, int month, int day)
            : base(year, month, day)
        {
            if (day > 31) throw new JanuaryComplaint();
        }
    }
}