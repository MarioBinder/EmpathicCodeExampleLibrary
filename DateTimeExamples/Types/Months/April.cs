using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Months
{
    public class April : Month<April>, IFindMonths
    {
        public int Month { get { return 4; } }

        public April(int year, int month, int day)
            : base(year, month, day)
        {
            if (day >= 31) throw new AprilComplaint();
        }


    }
}