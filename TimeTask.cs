namespace TaskManagerPro;

public class TimeTask : BaseTask
{
    public int Minutes { get; private set; }

    public TimeTask(string title, int minutes) : base(title)
    {
        Minutes = minutes;
    }

    public override void Display()
    {
        Console.WriteLine($"[Timed] {Title} ({Minutes} minutes) - Completed : {IsCompleted}");
    }
}