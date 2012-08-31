using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Months
{
    public class January : Month<January>, IFindMonth
    {
        public int Month { get { return 1; } }
        
        public static January In(int year)
        {
            return new January(year);
        }

        public January(int year)
        {
            Year = year;
        }
        public January(int year, int month, int day)
            : base(year, month, day)
        {
            if (day > 31) throw new JanuaryComplaint();
        }
    }
}