using System;
using System.Threading.Tasks;

public class LunchTask
{
    public string TaskName { get; set; } // Name of the task
    public int Duration { get; set; }     // Duration of the task in seconds

    public LunchTask(string taskName, int duration) // Constructor for LunchTask
    {
        TaskName = taskName;
        Duration = duration;
    }

    // Method to execute the task asynchronously
    public async Task ExecuteAsync()
    {
        Console.WriteLine(TaskName); // Display the task name
        await Task.Delay(Duration * 1000); // Wait for the specified duration in milliseconds
        Console.WriteLine($"{TaskName} done!"); // Indicate that the task is done
    }
}
