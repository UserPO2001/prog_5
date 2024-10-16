using System;  // Importing the System namespace which contains fundamental classes and base classes used for input and output operations.

namespace HouseAreaCalculation  // Declaring a namespace called HouseAreaCalculation to organize related classes.
{
    class Program  // Defining a class named Program, which contains the entry point of the application.
    {
        static void Main(string[] args)  // The Main method is the entry point of the program where execution begins.
        {
            TestClass calculator = new TestClass();  // Creating an instance of the TestClass named 'calculator' to access its methods for area calculation.

            // Displaying a welcome message to the user in the console.
            Console.WriteLine("Welkom! Voer de lengte en breedte in meters in voor elke ruimte van het huis.");

            // Prompting the user to enter dimensions for the living room.
            Console.WriteLine("Woonkamer:");
            double livingRoomArea = GetRoomArea(calculator);  // Calling the GetRoomArea method to calculate and store the area of the living room.

            // Prompting the user to enter dimensions for bedroom 1.
            Console.WriteLine("Slaapkamer 1:");
            double bedroom1Area = GetRoomArea(calculator);  // Calling the GetRoomArea method to calculate and store the area of bedroom 1.

            // Prompting the user to enter dimensions for bedroom 2.
            Console.WriteLine("Slaapkamer 2:");
            double bedroom2Area = GetRoomArea(calculator);  // Calling the GetRoomArea method to calculate and store the area of bedroom 2.

            // Prompting the user to enter dimensions for the attic.
            Console.WriteLine("Zolder:");
            double atticArea = GetRoomArea(calculator);  // Calling the GetRoomArea method to calculate and store the area of the attic.

            // Calculating the total area of the house by summing all individual room areas.
            double totalArea = livingRoomArea + bedroom1Area + bedroom2Area + atticArea;  // Storing the sum of all room areas in totalArea.

            // Displaying the total area of the house to the user in the console.
            Console.WriteLine($"De totale oppervlakte van het huis is {totalArea} m².");  // Using string interpolation to format the output message.
        }

        // Helper method to get room area from user input
        static double GetRoomArea(TestClass calculator)  // Declaring a method that takes an instance of TestClass as a parameter and returns a double.
        {
            Console.Write("Lengte (m): ");  // Prompting the user to enter the length of the room in meters.
            string lengthInput = Console.ReadLine();  // Reading the input from the console and storing it in lengthInput.

            Console.Write("Breedte (m): ");  // Prompting the user to enter the width of the room in meters.
            string widthInput = Console.ReadLine();  // Reading the input from the console and storing it in widthInput.

            // Attempting to parse the input as double first to accommodate decimal values.
            if (double.TryParse(lengthInput, out double length) && double.TryParse(widthInput, out double width))  // If both inputs can be parsed as doubles:
            {
                // Calling the CalculateArea method for double type and returning the calculated area.
                return calculator.CalculateArea(length, width);  // Invoking the CalculateArea method with double parameters and returning the result.
            }
            // If parsing as double fails, trying to parse as int for whole number values.
            else if (int.TryParse(lengthInput, out int lengthInt) && int.TryParse(widthInput, out int widthInt))  // If both inputs can be parsed as integers:
            {
                // Calling the CalculateArea method for int type and returning the calculated area.
                return calculator.CalculateArea(lengthInt, widthInt);  // Invoking the CalculateArea method with int parameters and returning the result.
            }
            else  // If the inputs cannot be parsed as either double or int:
            {
                // Displaying an error message if the input is invalid.
                Console.WriteLine("Ongeldige invoer. Voer a.u.b. een getal in.");  // Informing the user that the input was invalid.
                // Recursively calling GetRoomArea to prompt for valid input again.
                return GetRoomArea(calculator);  // Recalling the GetRoomArea method to allow the user to try again.
            }
        }
    }

    class TestClass  // Defining a class named TestClass that contains methods for area calculation.
    {
        // Overloading is the ability to create multiple methods with the same name 
        // but different parameter types or numbers. This allows us to call the 
        // same method name for different data types.
        
        // Overloaded method for int type
        public double CalculateArea(int length, int width)  // Declaring a method named CalculateArea that takes two integer parameters.
        {
            return length * width;  // Returning the calculated area by multiplying length and width.
        }

        // Overloaded method for double type
        public double CalculateArea(double length, double width)  // Declaring a method named CalculateArea that takes two double parameters.
        {
            return length * width;  // Returning the calculated area by multiplying length and width.
        }
    }
}
