
using TaskManagerPro;

var tasks = new List<ITask>
{
    new SimpleTask("Buy groceries"),
    new SimpleTask("Email Professor"),
    new TimeTask("Study algorithms", 45),
    new RecurringTask("Check Email", 3)
};

foreach (var task in tasks)
{
    task.Display();
}

tasks[0].Complete();

Console.WriteLine("\nAfter completing the first task:\n");

foreach (var task in tasks)
{
    task.Display();
}


