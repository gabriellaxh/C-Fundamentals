using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var people = new List<Person>();

        while (command != "End")
        {
            var info = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = info[0];

            var newPerson = people.Where(x => x.Name == name).FirstOrDefault();

            if (newPerson == null)
            {
                newPerson = new Person()
                {
                    Name = name,
                    Parents = new List<Parent>(),
                    Pokemons = new List<Pokemon>(),
                    Children = new List<Child>()
                };
            }

            string type = info[1];
            switch (type)
            {
                case "company":
                    string companyName = info[2];
                    string department = info[3];
                    decimal salary = decimal.Parse(info[4]);

                    var newComp = new Company()
                    {
                        CompanyName = companyName,
                        Department = department,
                        Salary = salary
                    };
                    newPerson.Company = newComp;
                    break;

                case "pokemon":
                    string pokemonName = info[2];
                    string pokemonType = info[3];
                    var newPokemon = new Pokemon()
                    {
                        PokemonName = pokemonName,
                        PokemonType = pokemonType
                    };
                    newPerson.Pokemons.Add(newPokemon);
                    break;

                case "parents":
                    string parentName = info[2];
                    string parentBirthday = info[3];
                    var newParent = new Parent()
                    {
                        ParentName = parentName,
                        ParentBirthday = parentBirthday
                    };
                    newPerson.Parents.Add(newParent);
                    break;

                case "children":
                    string childName = info[2];
                    string childBirthday = info[3];
                    var newChild = new Child()
                    {
                        ChildName = childName,
                        ChildBirthday = childBirthday
                    };
                    newPerson.Children.Add(newChild);
                    break;

                case "car":
                    string carModel = info[2];
                    string carSpeed = info[3];
                    var newCar = new Car()
                    {
                        CarModel = carModel,
                        CarSpeed = carSpeed
                    };
                    newPerson.Car = newCar;
                    break;
            }
            people.Add(newPerson);
            command = Console.ReadLine();
        }
        var name_ = Console.ReadLine();
        var person = people.Where(x => x.Name == name_).FirstOrDefault();
        Console.WriteLine($"{name_}");
        Console.WriteLine("Company:");
        if (person.Company != null)
        {
            Console.WriteLine($"{person.Company.CompanyName} {person.Company.Department} {person.Company.Salary:f2}");
        }

        Console.WriteLine("Car:");
        if (person.Car != null)
        {
            Console.WriteLine($"{person.Car.CarModel} {person.Car.CarSpeed}");
        }

        Console.WriteLine("Pokemon:");
        if (person.Pokemons.Count != 0)
        {
            foreach (var pokemon in person.Pokemons)
            {
                Console.WriteLine($"{pokemon.PokemonName} {pokemon.PokemonType}");
            };
        }
        Console.WriteLine("Parents:");
        if (person.Parents != null)
        {
            foreach (var parent in person.Parents)
            {
                Console.WriteLine($"{parent.ParentName} {parent.ParentBirthday}");
            };
        }
        Console.WriteLine("Children:");
        if (person.Children != null)
        {
            foreach (var child in person.Children)
            {
                Console.WriteLine($"{child.ChildName} {child.ChildBirthday}");
            };
        }
    }
}


