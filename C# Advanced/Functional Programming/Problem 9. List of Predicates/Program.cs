using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._List_of_Predicates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(int.Parse)
                                             .ToList();

            GetDivisibleNums(num, dividers);

        }

        private static void GetDivisibleNums(int num, List<int> dividers)
        {
            var list = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                int counter = 0;
                for (int d = 0; d < dividers.Count; d++)
                {
                    Func<int, bool> isDivisible = x => x % dividers[d] == 0;
                    if (isDivisible(i))
                    {
                        if (counter == dividers.Count - 1)
                        {
                            list.Add(i);
                        }
                        counter++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
