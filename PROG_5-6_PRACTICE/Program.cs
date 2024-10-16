using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting the pre-flight checklist...");

        Checklist checklist = new Checklist();
        await checklist.ExecuteChecklistAsync();

        Console.WriteLine("All checks completed. Ready for takeoff!");
    }
}
