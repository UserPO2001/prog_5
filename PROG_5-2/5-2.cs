using System; // Importing the System namespace to use basic functionalities like console input/output.

namespace HouseAreaCalculation // Declaring a namespace called HouseAreaCalculation to organize the code and avoid naming conflicts.
{
    class Program // Defining a class named Program, which serves as the entry point of the application.
    {
        static void Main(string[] args) // The Main method is the starting point of the program execution.
        {
            TestClass calculator = new TestClass(); // Creating an instance of the TestClass to use its methods for area calculations.

            Console.WriteLine("Welkom! Voer de lengte en breedte in meters in voor elke ruimte van het huis."); 
            // Printing a welcome message to the console, prompting the user to enter dimensions for each room in meters.

            // Woonkamer
            Console.WriteLine("Woonkamer:"); // Indicating that the user should input dimensions for the living room.
            double livingRoomArea = GetRoomArea(calculator); // Calling the GetRoomArea method to get the area of the living room.

            // Slaapkamer 1
            Console.WriteLine("Slaapkamer 1:"); // Indicating that the user should input dimensions for bedroom 1.
            double bedroom1Area = GetRoomArea(calculator); // Calling the GetRoomArea method to get the area of bedroom 1.

            // Slaapkamer 2
            Console.WriteLine("Slaapkamer 2:"); // Indicating that the user should input dimensions for bedroom 2.
            double bedroom2Area = GetRoomArea(calculator); // Calling the GetRoomArea method to get the area of bedroom 2.

            // Zolder
            Console.WriteLine("Zolder:"); // Indicating that the user should input dimensions for the attic.
            double atticArea = GetRoomArea(calculator); // Calling the GetRoomArea method to get the area of the attic.

            // Totale oppervlakte
            double totalArea = livingRoomArea + bedroom1Area + bedroom2Area + atticArea; 
            // Calculating the total area by summing up the areas of all rooms.
            Console.WriteLine($"De totale oppervlakte van het huis is {totalArea} m²."); 
            // Printing the total area to the console in square meters.
        }

        // Helper method to get room area from user input
        static double GetRoomArea(TestClass calculator) // Defining a method to get the area of a room based on user input.
        {
            Console.Write("Lengte (m): "); // Prompting the user to enter the length of the room in meters.
            string lengthInput = Console.ReadLine(); // Reading the user input for length.
            Console.Write("Breedte (m): "); // Prompting the user to enter the width of the room in meters.
            string widthInput = Console.ReadLine(); // Reading the user input for width.

            // Try to parse as double first
            if (double.TryParse(lengthInput, out double length) && double.TryParse(widthInput, out double width))
            {
                // If both inputs can be parsed as doubles, call the CalculateArea method with double parameters.
                return calculator.CalculateArea(length, width);
            }
            // Try to parse as int if double parsing fails
            else if (int.TryParse(lengthInput, out int lengthInt) && int.TryParse(widthInput, out int widthInt))
            {
                // If both inputs can be parsed as integers, call the CalculateArea method with int parameters.
                return calculator.CalculateArea(lengthInt, widthInt);
            }
            else
            {
                Console.WriteLine("Ongeldige invoer. Voer a.u.b. een getal in."); 
                // If the input is invalid, print an error message.
                return GetRoomArea(calculator); // Retry on invalid input by calling GetRoomArea again.
            }
        }
    }

    class TestClass // Defining a class named TestClass that contains methods for calculations.
    {
        // Overloading is the ability to create multiple methods with the same name 
        // but different parameter types or numbers. This allows us to call the 
        // same method name for different data types.
        
        // Overloaded method for int type
        public double CalculateArea(int length, int width) 
        {
            return length * width; // Calculating area for integer parameters.
        }

        // Overloaded method for double type
        public double CalculateArea(double length, double width) 
        {
            return length * width; // Calculating area for double parameters.
        }
    }
}
