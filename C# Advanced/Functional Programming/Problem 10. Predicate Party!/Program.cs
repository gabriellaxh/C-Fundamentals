using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10._Predicate_Party_
{
    public class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filteredGuests = new List<string>();

            FilterGuests(guests, commands, filteredGuests);

            while (commands[0] != "Party!")
            {
                if (commands[0] == "Remove")
                {
                    guests = guests.Where(x => !filteredGuests.Contains(x)).ToList();
                }
                else if (commands[0] == "Double")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        for (int j = 0; j < filteredGuests.Count; j++)
                        {
                            if (guests[i] == filteredGuests[j])
                            {
                                guests.Insert(++i, filteredGuests[j]);
                                filteredGuests.RemoveAt(j);

                            }
                        }
                    }
                }
                commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "Party!")
                {
                    if (guests.Count == 0)
                    {
                        Console.WriteLine("Nobody is going to the party!");
                        return;
                    }
                    Console.Write(string.Join(", ", guests));
                    Console.Write(" ");
                    Console.WriteLine("are going to the party!");
                    return;
                }
                FilterGuests(guests, commands, filteredGuests);
            }
            Console.WriteLine(string.Join(" ", guests));
        }


        private static void FilterGuests(List<string> guests, string[] commands, List<string> filteredGuests)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                switch (commands[1])
                {
                    case "StartsWith":
                        if (guests[i].StartsWith(commands[2]))
                        {
                            filteredGuests.Add(guests[i]);
                        }
                        break;

                    case "EndsWith":
                        if (guests[i].EndsWith(commands[2]))
                        {
                            filteredGuests.Add(guests[i]);
                        }
                        break;

                    case "Length":
                        if (guests[i].Length == int.Parse(commands[2]))
                        {
                            filteredGuests.Add(guests[i]);
                        }
                        break;
                }
            }
        }
    }
}
