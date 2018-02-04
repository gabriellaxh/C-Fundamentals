using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Find_Evens_or_Odds
{
    public class Program
    {
        static void Main(string[] args)
        {
            var boundaries = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string evenOrOdd = Console.ReadLine();

            Predicate<int> isEven = x => x % 2 == 0;

            var numbers = GetNumbers(boundaries, evenOrOdd, isEven);
            if(numbers.Count != 0)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }

        private static List<int> GetNumbers(List<int> boundaries,string evenOrOdd, Predicate<int> isEven)
        {
            var nums = new List<int>();

            for (int i = boundaries[0]; i <= boundaries[1]; i++)
            {
                if ((isEven(i) && evenOrOdd == "even") || (!isEven(i) && evenOrOdd == "odd"))
                {
                    nums.Add(i);
                }
            }
            return nums;
        }
    }
}
