using System;
using System.Collections.Generic;

public class PokemonTrainer
{
    public string Naam { get; set; }
    public List<Pokemon> PokemonLijst { get; set; }

    public PokemonTrainer(string naam)
    {
        Naam = naam;
        PokemonLijst = new List<Pokemon>(); // Lege lijst van Pokémon
    }

    // Methode om een Pokémon toe te voegen aan de lijst
    public void VoegPokemonToe(Pokemon pokemon)
    {
        PokemonLijst.Add(pokemon);
    }

    // Methode om een Pokémon te verwijderen op basis van de naam
    public void VerwijderPokemon(string naam)
    {
        Pokemon pokemonToRemove = PokemonLijst.Find(p => p.Naam.Equals(naam, StringComparison.OrdinalIgnoreCase));
        if (pokemonToRemove != null)
        {
            PokemonLijst.Remove(pokemonToRemove);
            Console.WriteLine($"Pokémon {naam} is verwijderd.");
        }
        else
        {
            Console.WriteLine($"Pokémon {naam} niet gevonden.");
        }
    }

    // Overloaded method om een Pokémon te verwijderen op basis van de index
    public void VerwijderPokemon(int index)
    {
        if (index >= 0 && index < PokemonLijst.Count)
        {
            Pokemon verwijderdePokemon = PokemonLijst[index];
            PokemonLijst.RemoveAt(index);
            Console.WriteLine($"Pokémon {verwijderdePokemon.Naam} is verwijderd.");
        }
        else
        {
            Console.WriteLine("Ongeldige index.");
        }
    }

    // Methode om een Pokémon te kiezen
    public Pokemon KiesPokemon()
    {
        Console.WriteLine($"Kies een Pokémon voor trainer {Naam}:");
        for (int i = 0; i < PokemonLijst.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {PokemonLijst[i].Naam} (Niveau: {PokemonLijst[i].Niveau}, HP: {PokemonLijst[i].HP})");
        }

        int keuze;
        while (true)
        {
            Console.Write("Voer het nummer in van de Pokémon die je wilt kiezen: ");
            if (int.TryParse(Console.ReadLine(), out keuze) && keuze >= 1 && keuze <= PokemonLijst.Count)
            {
                return PokemonLijst[keuze - 1];
            }
            Console.WriteLine("Ongeldige keuze. Probeer het opnieuw.");
        }
    }
}
