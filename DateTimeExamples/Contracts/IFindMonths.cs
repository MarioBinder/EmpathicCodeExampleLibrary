namespace DateTimeExamples.Contracts
{
    public interface IFindMonths
    {
        int Year { get; set; }
        int Month { get; }
        string DayName { get; }
    }
}