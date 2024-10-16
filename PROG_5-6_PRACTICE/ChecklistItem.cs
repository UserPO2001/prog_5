using System;
using System.Threading.Tasks;

public class ChecklistItem
{
    public string Description { get; }
    public int Duration { get; }

    public ChecklistItem(string description, int duration)
    {
        Description = description;
        Duration = duration;
    }

    public async Task ExecuteAsync()
    {
        Console.WriteLine(Description);
        await Task.Delay(Duration * 1000); // Convert seconds to milliseconds
        Console.WriteLine($"{Description} done!");
    }
}
