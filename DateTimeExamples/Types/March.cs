using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types
{
    public class March : Month<March>, IFindMonth
    {
        public March(int year, int day)
            : base(year, day)
        {
            if (day >= 31) throw new MarchComplaint();
            _Month = 2;
        }
    }
}