using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types
{
    public class April : Month<April>, IFindMonth
    {
        public April(int year, int day)
            : base(year, day)
        {
            if (day >= 31) throw new AprilComplaint();
            _Month = 2;
        }
    }
}