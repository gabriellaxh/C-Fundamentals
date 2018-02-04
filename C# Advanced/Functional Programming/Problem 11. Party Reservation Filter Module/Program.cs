using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11._Party_Reservation_Filter_Module
{
    public class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var initialList = new List<string>();
            foreach (var g in guests)
            {
                initialList.Add(g);
            }

            var filteredGuests = new List<string>();

            while (commands[0] != "Print")
            {
                switch (commands[0])
                {
                    case "Add filter":
                        switch (commands[1])
                        {
                            case "Starts with":
                                Predicate<string> checkStart = x => x.StartsWith(commands[2]);
                                filteredGuests = guests.Where(x => !checkStart(x)).ToList();
                                guests = filteredGuests;
                                break;

                            case "Ends with":
                                Predicate<string> checkEnd = x => x.EndsWith(commands[2]);
                                filteredGuests = guests.Where(x => !checkEnd(x)).ToList();
                                guests = filteredGuests;
                                break;

                            case "Length":
                                Predicate<string> checkLen = x => x.Length == int.Parse(commands[2]);
                                filteredGuests = guests.Where(x => !checkLen(x)).ToList();
                                guests = filteredGuests;
                                break;

                            case "Contains":
                                Predicate<string> checkContains = x => x.Contains(commands[2]);
                                filteredGuests = guests.Where(x => !checkContains(x)).ToList();
                                guests = filteredGuests;
                                break;
                        }
                        break;

                    case "Remove filter":
                        switch (commands[1])
                        {
                            case "Starts with":
                                Predicate<string> checkStart = x => x.StartsWith(commands[2]);
                                for (int i = 0; i < initialList.Count; i++)
                                {
                                    if (checkStart(initialList[i]))
                                    {
                                        guests.Insert(0, initialList[i]);

                                        break;
                                    }
                                }
                                guests = filteredGuests;
                                break;

                            case "Ends with":
                                Predicate<string> checkEnd = x => x.EndsWith(commands[2]);

                                for (int i = 0; i < initialList.Count; i++)
                                {
                                    if (checkEnd(initialList[i]))
                                    {
                                        guests.Insert(0, initialList[i]);

                                        break;
                                    }
                                }
                                guests = filteredGuests;
                                break;

                            case "Length":
                                Predicate<string> checkLen = x => x.Length == int.Parse(commands[2]);
                                for (int i = 0; i < initialList.Count; i++)
                                {
                                    if (checkLen(initialList[i]))
                                    {
                                        guests.Insert(0, initialList[i]);

                                        break;
                                    }
                                }
                                guests = filteredGuests;
                                break;

                            case "Contains":
                                Predicate<string> checkContains = x => x.Contains(commands[2]);
                                for (int i = 0; i < initialList.Count; i++)
                                {
                                    if (checkContains(initialList[i]))
                                    {
                                        guests.Insert(0, initialList[i]);

                                        break;
                                    }
                                }
                                guests = filteredGuests;
                                break;
                        }
                        break;
                }
                commands = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine(string.Join(" ",guests));
        }
    }
}
