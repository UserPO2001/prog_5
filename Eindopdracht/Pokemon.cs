using System;

public class Pokemon
{
    public string Naam { get; set; }
    public string Type { get; set; }
    public int Niveau { get; private set; } // Niveau mag alleen worden gewijzigd via de methoden in deze klasse
    public int HP { get; set; }
    public int XP { get; private set; } // Totale ervaringspunten

    private const int XP_VEREIST_PER_NIVEAU = 100; // Vereiste XP om naar het volgende niveau te stijgen

    // Constructor om een nieuwe Pokémon te maken
    public Pokemon(string naam, string type, int niveau, int hp)
    {
        Naam = naam;
        Type = type;
        Niveau = niveau;
        HP = hp;
        XP = 0; // Start met 0 XP
    }

    // Methode om te vechten
    public void Vecht(string tegenstander, int verlorenHP)
    {
        if (verlorenHP < 0)
        {
            Console.WriteLine("Verloren HP moet een positieve waarde zijn.");
            return;
        }

        if (HP <= 0)
        {
            Console.WriteLine($"{Naam} kan niet vechten omdat het HP 0 of minder is.");
            return;
        }

        HP -= verlorenHP;

        if (HP < 0)
        {
            HP = 0; // Zorg ervoor dat HP niet negatief wordt
        }

        Console.WriteLine($"{Naam} heeft gevochten tegen {tegenstander} en {verlorenHP} HP verloren. Huidige HP: {HP}");
    }

    // Methode om XP toe te voegen en niveau omhoog te gaan
    public void VoegXPToe(int xp)
    {
        XP += xp;

        // Controleer of de Pokémon genoeg XP heeft om te levelen
        while (XP >= XP_VEREIST_PER_NIVEAU)
        {
            XP -= XP_VEREIST_PER_NIVEAU;
            Niveau++;
            Console.WriteLine($"{Naam} is nu niveau {Niveau}!");
        }
    }
}
