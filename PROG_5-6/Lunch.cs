using System.Collections.Generic;
using System.Threading.Tasks;

public class Lunch
{
    private List<LunchTask> _tasks; // List to hold lunch tasks

    public Lunch() // Constructor for the Lunch class
    {
        _tasks = new List<LunchTask>
        {
            new LunchTask("Pour coffee", 2),      // Task 1
            new LunchTask("Fry eggs", 5),          // Task 2
            new LunchTask("Fry bacon", 2),         // Task 3
            new LunchTask("Bacon cooking", 5),     // Task 4
            new LunchTask("Toast bread", 2),       // Task 5
            new LunchTask("Toast pops", 2),        // Task 6
            new LunchTask("Jam on bread", 2),      // Task 7
            new LunchTask("Pour Juice", 2)         // Task 8
        };
    }

    // Method to execute all lunch tasks asynchronously
    public async Task ExecuteLunchTasksAsync()
    {
        foreach (var task in _tasks)
        {
            await task.ExecuteAsync(); // Execute each task asynchronously
        }
    }
}
