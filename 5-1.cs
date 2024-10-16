// By including using System;, 
// you're telling the program to use the System namespace 
// so you can call classes like Console without specifying the full name (System.Console).

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their birthdate
        Console.WriteLine("Voer je geboortedatum in (dd-mm-yyyy): ");
        
        // Parse the input as a DateTime object
        string input = Console.ReadLine();
        DateTime birthDate;

        // Validate if the input is in correct format
        if (DateTime.TryParseExact(input, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
        {
            // Calculate the age
            int age = CalculateAge(birthDate);

            // Display different messages based on age
            if (age >= 19)
            {
                Console.WriteLine("Drink bier in plaats van water, dan heb je morgen een flinke kater.");
            }
            else if (age < 18)
            {
                Console.WriteLine("Je mag nog geen alcohol drinken.");
            }
            else
            {
                Console.WriteLine("Je bent 18 jaar oud!");
            }
        }
        else
        {
            Console.WriteLine("Ongeldige datum. Probeer het opnieuw.");
        }
    }

    // Method to calculate age based on birthdate
    static int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Now;
        int age = today.Year - birthDate.Year;

        // If the birthday hasn't occurred yet this year, subtract one year from the age
        if (today < birthDate.AddYears(age))
        {
            age--;
        }
        return age;
    }
}
