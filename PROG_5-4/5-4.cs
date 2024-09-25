using System;

// Base class Boek
class Boek
{
    // Private class members
    private string isbn;
    private string auteur;
    private string titel;
    private int jaarVanDruk;
    private string uitgever;

    // Constructor
    public Boek(string isbn, string auteur, string titel, int jaarVanDruk, string uitgever)
    {
        this.isbn = isbn;
        this.auteur = auteur;
        this.titel = titel;
        this.jaarVanDruk = jaarVanDruk;
        this.uitgever = uitgever;
    }

    // Getters and Setters
    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public string Auteur
    {
        get { return auteur; }
        set { auteur = value; }
    }

    public string Titel
    {
        get { return titel; }
        set { titel = value; }
    }

    public int JaarVanDruk
    {
        get { return jaarVanDruk; }
        set { jaarVanDruk = value; }
    }

    public string Uitgever
    {
        get { return uitgever; }
        set { uitgever = value; }
    }

    // Method to display book details
    public void ToonDetails()
    {
        Console.WriteLine($"ISBN: {isbn}, Auteur: {auteur}, Titel: {titel}, Jaar van druk: {jaarVanDruk}, Uitgever: {uitgever}");
    }
}

// Derived class Schoolboeken
class Schoolboeken : Boek
{
    public Schoolboeken(string isbn, string auteur, string titel, int jaarVanDruk, string uitgever)
        : base(isbn, auteur, titel, jaarVanDruk, uitgever)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a Schoolboeken object (which inherits from Boek)
        Schoolboeken boek1 = new Schoolboeken("123-456-789", "J.K. Rowling", "Harry Potter", 1997, "Bloomsbury");

        // Display original details
        boek1.ToonDetails();

        // Using setters to change details
        boek1.Titel = "Harry Potter and the Philosopher's Stone";
        boek1.JaarVanDruk = 1998;

        // Display updated details
        Console.WriteLine("\nUpdated Details:");
        boek1.ToonDetails();
    }
}
