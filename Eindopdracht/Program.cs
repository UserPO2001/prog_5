using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Pokémon
        List<Pokemon> availablePokemon = new List<Pokemon>
        {
            new Pokemon("Pikachu", "Electric", 5, 35),
            new Pokemon("Charmander", "Fire", 5, 39),
            new Pokemon("Squirtle", "Water", 5, 44),
            new Pokemon("Bulbasaur", "Grass", 5, 45),
            new Pokemon("Jigglypuff", "Normal", 5, 115),
            new Pokemon("Meowth", "Normal", 5, 40),
            new Pokemon("Psyduck", "Water", 5, 50),
            new Pokemon("Gengar", "Ghost", 5, 60),
            new Pokemon("Onix", "Rock/Ground", 5, 35),
            new Pokemon("Eevee", "Normal", 5, 55)
        };

        // Create two Pokémon Trainers
        PokemonTrainer trainer1 = new PokemonTrainer("Ash Ketchum");
        PokemonTrainer trainer2 = new PokemonTrainer("Gary Oak");

        // Allow each trainer to select Pokémon
        SelectPokemonForTrainer(trainer1, availablePokemon);
        SelectPokemonForTrainer(trainer2, availablePokemon);

        // Start the battle
        StartBattle(trainer1, trainer2);
    }

    static void SelectPokemonForTrainer(PokemonTrainer trainer, List<Pokemon> availablePokemon)
    {
        Console.WriteLine($"{trainer.Naam}, kies tot 3 Pokémon uit de volgende lijst:");

        for (int i = 0; i < availablePokemon.Count; i++)
        {
            Console.WriteLine($"{i}: {availablePokemon[i].Naam} ({availablePokemon[i].Type})");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Kies Pokémon {i + 1} (0-{availablePokemon.Count - 1}):");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 0 && choice < availablePokemon.Count)
            {
                trainer.VoegPokemonToe(availablePokemon[choice]);
                Console.WriteLine($"{availablePokemon[choice].Naam} is toegevoegd aan je team!");
                availablePokemon.RemoveAt(choice); // Remove selected Pokémon from the available list
            }
            else
            {
                Console.WriteLine("Ongeldige keuze, probeer het opnieuw.");
                i--; // Repeat the selection for the current Pokémon
            }
        }
    }

    static void StartBattle(PokemonTrainer trainer1, PokemonTrainer trainer2)
    {
        Console.WriteLine($"Battle tussen {trainer1.Naam} en {trainer2.Naam}!");

        Random random = new Random(); // Random object for generating damage

        // Continue the battle until one trainer's Pokémon are all fainted
        while (trainer1.PokemonLijst.Count > 0 && trainer2.PokemonLijst.Count > 0)
        {
            Pokemon pokemon1 = trainer1.KiesPokemon();
            Pokemon pokemon2 = trainer2.KiesPokemon();

            while (pokemon1.HP > 0 && pokemon2.HP > 0)
            {
                Console.WriteLine($"{pokemon1.Naam} vecht tegen {pokemon2.Naam}!");

                // Generate random damage between 1 and 20
                int damageToPokemon2 = random.Next(1, 21);
                pokemon1.Vecht(pokemon2.Naam, damageToPokemon2);
                Console.WriteLine($"{pokemon2.Naam} heeft {damageToPokemon2} schade gekregen! HP over: {pokemon2.HP}");
                Thread.Sleep(3000); // Wait 3 seconds

                if (pokemon2.HP > 0) // Ensure we don't continue if Pokémon 2 has already fainted
                {
                    int damageToPokemon1 = random.Next(1, 21);
                    pokemon2.Vecht(pokemon1.Naam, damageToPokemon1);
                    Console.WriteLine($"{pokemon1.Naam} heeft {damageToPokemon1} schade gekregen! HP over: {pokemon1.HP}");
                    Thread.Sleep(3000); // Wait 3 seconds
                }
            }

            // Determine the outcome of the battle between these Pokémon
            if (pokemon1.HP <= 0)
            {
                Console.WriteLine($"{pokemon1.Naam} is verslagen!");
                trainer1.PokemonLijst.Remove(pokemon1); // Remove fainted Pokémon from the trainer's list
                Thread.Sleep(3000); // Wait 3 seconds
            }
            else if (pokemon2.HP <= 0)
            {
                Console.WriteLine($"{pokemon2.Naam} is verslagen!");
                trainer2.PokemonLijst.Remove(pokemon2); // Remove fainted Pokémon from the trainer's list
                Thread.Sleep(3000); // Wait 3 seconds
            }
        }

        // Declare the winner
        if (trainer1.PokemonLijst.Count == 0)
        {
            Console.WriteLine($"{trainer2.Naam} wint de strijd!");
        }
        else if (trainer2.PokemonLijst.Count == 0)
        {
            Console.WriteLine($"{trainer1.Naam} wint de strijd!");
        }
    }
}
