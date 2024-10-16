using System;

class Student
{
    // Class members (attributes) of Student
    public string Name;
    public int Age;
    public string Grade;
    public string Major;

   
    public Student()
    {
        Name = "Peter Oosterbroek";
        Age = 23;
        Education = "MBO-4";
        Major = "Software Dev";
    }

    // Method to display the student details
    public void ShowStudentInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, Education: {Education}, Major: {Major}");
    }
}

class Schoolvak
{
    // Class members (attributes) of Schoolvak
    public string SubjectName;
    public string Teacher;
    public int Credits;
    public string DifficultyLevel;

    // Constructor to set default values
    public Schoolvak()
    {
        SubjectName = "Programming";
        Teacher = "Mrs. Smith";
        Credits = 3;
        DifficultyLevel = "Intermediate";
    }

    // Method to display the subject details
    public void ShowSubjectInfo()
    {
        Console.WriteLine($"Subject: {SubjectName}, Teacher: {Teacher}, Credits: {Credits}, Difficulty: {DifficultyLevel}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Student and Schoolvak with default values
        Student student = new Student();
        Schoolvak schoolvak = new Schoolvak();

        // Display the default values
        student.ShowStudentInfo();
        schoolvak.ShowSubjectInfo();
    }
}