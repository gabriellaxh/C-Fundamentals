using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var info = Console.ReadLine();
        var pokemons = new List<Pokemon>();
        var trainers = new List<Trainer>();

        while (info != "Tournament")
        {
            var line = info.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string trainerName = line[0];
            string pokemonName = line[1];
            string pokemonElement = line[2];
            int pokemontHealth = int.Parse(line[3]);

            if (!trainers.Any(x => x.Name == trainerName))
            {
                var trainer = new Trainer()
                {
                    Name = trainerName,
                    Pokemons = new List<Pokemon>()
                };
                trainers.Add(trainer);
            }
            var newPokemon = new Pokemon()
            {
                Name = pokemonName,
                Element = pokemonElement,
                Health = pokemontHealth
            };

            var trainer_ = trainers.Where(x => x.Name == trainerName).FirstOrDefault();
            trainer_.Pokemons.Add(newPokemon);

            info = Console.ReadLine();
        }
        var command = Console.ReadLine();
        while (command != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(x => x.Element == command))
                {
                    trainer.Badges += 1;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Health - 10 > 0)
                            pokemon.Health -= 10;
                        else
                        {
                            trainer.Pokemons.Remove(pokemon);
                            break;
                        }
                    }
                }
            }
            command = Console.ReadLine();
        }
        foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
}


