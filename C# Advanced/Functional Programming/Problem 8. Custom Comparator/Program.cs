using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8._Custom_Comparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToArray();

            Func<int, bool> isEven = x => x % 2 == 0;
            SortNums(nums, isEven);
        }

        private static void SortNums(int[] nums, Func<int, bool> isEven)
        {
            var evenList = nums.Where(x => isEven(x) == true).ToArray();
            var oddList = nums.Where(x => isEven(x) == false).ToArray();
            Array.Sort(evenList);
            Array.Sort(oddList);


            Console.Write(string.Join(" ", evenList));
            Console.Write(" ");
            Console.WriteLine(string.Join(" ", oddList));

        }
    }
}
