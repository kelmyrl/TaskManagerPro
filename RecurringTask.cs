namespace TaskManagerPro;

public class RecurringTask : BaseTask
{
    public int RecurringTimes { get; protected set; }

    public RecurringTask(string title, int recurringTimes) : base(title)
    {
        RecurringTimes = recurringTimes;
    }

    public override void Display()
    {
        Console.WriteLine($"[Recurring] {Title} (Repeats {RecurringTimes} times) - Completed : {IsCompleted}");
    }
}