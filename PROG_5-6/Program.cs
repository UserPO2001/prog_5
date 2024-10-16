using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Making us some lunch darling...");

        Lunch lunch = new Lunch(); // Create a new Lunch instance
        await lunch.ExecuteLunchTasksAsync(); // Execute all lunch tasks asynchronously

        Console.WriteLine("Lunch's ready darling!");
    }
}
