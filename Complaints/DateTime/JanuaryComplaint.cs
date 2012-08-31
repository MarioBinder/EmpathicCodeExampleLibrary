namespace Complaints.DateTime
{
    public class JanuaryComplaint : MonthComplaint
    {
        public override string Message
        {
            get
            {
                return "Last Day of January is the 31.";
            }
        }
    }
}