using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Reverse_and_Exclude
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();

            var divideBy = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = x => x % divideBy == 0;

            var desiredNums = nums.Where(x => !isDivisible(x)).Reverse().ToList();
            Console.WriteLine(string.Join(" ",desiredNums));
            
        }
    }
}
