namespace InversionOfControlProject_VS
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void PerformedWork(double hours);
        void CompleteWork();

    }
}