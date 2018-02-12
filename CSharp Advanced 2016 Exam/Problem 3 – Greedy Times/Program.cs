using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_3___Greedy_Times
{
    public class Program
    {
        static void Main(string[] args)
        {
            long capacity = long.Parse(Console.ReadLine());
            var initialItems = Console.ReadLine();
            var items = initialItems.ToLower();

            long gold = 0;
            var gems = new Dictionary<string, long>();
            var cash = new Dictionary<string, long>();

            long currentWeight = 0;

            var goldRegex = string.EndsWith("ge;
            var goldMatches = goldRegex.Matches(items);

            foreach (Match match in goldMatches)
            {
                long quantity = long.Parse(match.Groups[2].Value);
                if (currentWeight + quantity <= capacity)
                {
                    currentWeight += quantity;
                    gold += quantity;
                }
            }

            var gemRegex = new Regex(@"(\w+gem)\s{1}(\d+)");
            var gemMatches = gemRegex.Matches(items).OrderByDescending(x => x.Value).ToList();
            long gemCount = 0;
            foreach (Match match in gemMatches)
            {
                string name = match.Groups[1].Value;
                long quantity = long.Parse(match.Groups[2].Value);
                gemCount += quantity;

                if (currentWeight + quantity <= capacity && gemCount <= gold)
                {
                    currentWeight += quantity;
                    foreach (var item in initialItems.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (item.ToLower() == name)
                        {
                            gems.Add(item, quantity);
                        }
                    }

                }
            }

            var cashRegex = new Regex(@"(\b[a-z]{3})\s{1}(\d+)");
            var cashMatches = cashRegex.Matches(items).OrderBy(x => x.Value).ToList();
            long cashCount = 0;
            foreach (Match match in cashMatches)
            {
                long quantity = long.Parse(match.Groups[2].Value);
                cashCount += quantity;

                if (currentWeight + quantity <= capacity && cashCount <= gemCount)
                {
                    currentWeight += quantity;
                    cash.Add(match.Groups[1].Value, quantity);
                }
            }
            


            PrintResult(gold, gems, cash);
        }

        private static void PrintResult(long gold, Dictionary<string, long> gems, Dictionary<string, long> cash)
        {
            Console.WriteLine($"<Gold> ${gold}");
            Console.WriteLine($"##Gold - {gold}");

            long gemsSum = gems.Sum(g => g.Value);
            if (gemsSum > 0)
            {
                Console.WriteLine($"<Gem> ${gemsSum}");
                foreach (var gem in gems.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{gem.Key} - {gem.Value}");
                }
            }

            long cashSum = cash.Sum(c => c.Value);
            if (cashSum > 0)
            {
                Console.WriteLine($"<Cash> ${cashSum}");
                foreach (var ca in cash.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{ca.Key.ToUpper()} - {ca.Value}");
                }
            }
        }
    }
}
