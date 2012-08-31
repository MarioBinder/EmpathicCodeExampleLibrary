using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types.Months
{
    public class March : Month<March>, IFindMonth
    {
        public March(int year, int month, int day)
            : base(year, month, day)
        {
            if (day >= 31) throw new MarchComplaint();
        }
    }
}