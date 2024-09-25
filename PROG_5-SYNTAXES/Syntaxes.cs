using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Variables and Data Types
            // Variables store data of different types
            int age = 25;
            string name = "Alice";
            double price = 19.99;
            bool isAvailable = true;

            Console.WriteLine($"Name: {name}, Age: {age}, Price: {price}, Available: {isAvailable}");

            // 2. Conditionals (if, else, else if)
            // Checks conditions and runs different code based on the result
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            // 3. Loops
            // For loop repeats code a set number of times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For Loop: " + i);
            }

            // While loop repeats as long as the condition is true
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("While Loop: " + count);
                count++;
            }

            // Foreach loop iterates through all elements in a collection (like an array)
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Foreach Loop: " + fruit);
            }

            // 4. Methods (Functions)
            // A block of code that performs a specific task, defined once and reused
            Greet("Alice");

            // 5. Classes and Objects
            // Classes define templates for creating objects, which are instances of classes
            Person person = new Person();
            person.Name = "Alice";
            person.Age = 25;
            person.Greet();

            // 6. Constructors
            // Special methods in a class that are called when an object is created
            Person anotherPerson = new Person("Bob", 30);
            anotherPerson.Greet();

            // 7. Properties
            // Properties are like variables but provide controlled access to private data
            anotherPerson.Name = "Charlie";
            Console.WriteLine("Updated Name: " + anotherPerson.Name);

            // 8. Inheritance
            // A class can inherit from another class to gain its behavior
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();

            // 9. Interfaces
            // Define methods that must be implemented by a class
            IAnimal animal = new Dog();
            animal.MakeSound();

            // 10. Arrays
            // Arrays store multiple values of the same type
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("First Number: " + numbers[0]);

            // 11. Try-Catch for Error Handling
            // Handles errors or exceptions that may occur during execution
            try
            {
                int num = int.Parse("abc");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            // 12. Enums
            // A special type to define a set of named constants
            Day today = Day.Monday;
            Console.WriteLine("Today is: " + today);

            // 13. Switch Statement
            // Allows multiple conditions to be checked in a simple way
            switch (today)
            {
                case Day.Monday:
                    Console.WriteLine("It's Monday.");
                    break;
                case Day.Friday:
                    Console.WriteLine("It's Friday.");
                    break;
                default:
                    Console.WriteLine("Another day.");
                    break;
            }

            // 14. Generics
            // Allow classes and methods to work with any data type
            MyClass<int> myIntClass = new MyClass<int>();
            myIntClass.Data = 10;
            Console.WriteLine("Generic Class Data: " + myIntClass.Data);

            // 15. LINQ (Language Integrated Query)
            // LINQ is used to query collections of data in a readable way
            int[] nums = { 1, 2, 3, 4, 5 };
            var evenNumbers = from n in nums
                              where n % 2 == 0
                              select n;

            foreach (var number in evenNumbers)
            {
                Console.WriteLine("Even Number: " + number);
            }
        }

        // A simple method example
        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }

    // A class representing a person
    class Person
    {
        // Properties for name and age
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor that takes name and age as parameters
        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method for greeting
        public void Greet()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }

    // Inheritance example - Dog class inherits from Animal
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog : Animal, IAnimal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }

        // Implementing the interface method
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }

    // Interface example
    interface IAnimal
    {
        void MakeSound();
    }

    // Enum example
    enum Day
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

    // Generic class example
    class MyClass<T>
    {
        public T Data { get; set; }
    }
}
