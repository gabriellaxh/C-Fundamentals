using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___Hit_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            int targetInfoIndex = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (command != "end transmissions")
            {
                var info = command.Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (!dictionary.ContainsKey(info[0]))
                {
                    dictionary[info[0]] = new Dictionary<string, string>();
                }
                var splitted = command.Substring(info[0].Length + 1).Split(new[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < splitted.Length; i += 2)
                {
                    if (!dictionary[info[0]].ContainsKey(splitted[i]))
                    {
                        dictionary[info[0]][splitted[i]] = string.Empty;
                    }
                    dictionary[info[0]][splitted[i]] = splitted[i + 1];
                }
                command = Console.ReadLine();
            }

            string toKill = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];

            Console.WriteLine($"Info on {toKill}:");
            foreach (var info in dictionary[toKill].OrderBy(x => x.Key))
            {
                Console.WriteLine($"---{info.Key}: {info.Value}");                
            }

            long infoIndex = dictionary[toKill].Sum(x => x.Key.Length) + dictionary[toKill].Sum(x => x.Value.Length);
            Console.WriteLine($"Info index: {infoIndex}");
            if (infoIndex >= targetInfoIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {targetInfoIndex - infoIndex} more info.");
            }

        }
    }
}
