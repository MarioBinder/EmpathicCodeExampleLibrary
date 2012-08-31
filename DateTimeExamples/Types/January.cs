using Complaints.DateTime;
using DateTimeExamples.Base;
using DateTimeExamples.Contracts;

namespace DateTimeExamples.Types
{
    public class January : Month<January>, IFindMonth
    {
        public January(int year, int day)
            : base(year, day)
        {
            if (day > 31) throw new JanuaryComplaint();
            _Month = 1;
        }
    }
}