namespace Complaints.DateTime
{
    public class FebruaryComplaint : MonthComplaint
    {
        public override string Message
        {
            get
            {
                return "Last Day of February is the 28. In the LeapYear the 29.";
            }
        }
    }
}