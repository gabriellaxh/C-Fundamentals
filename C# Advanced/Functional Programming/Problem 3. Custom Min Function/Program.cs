using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();
            Func<List<int>, int> getSmallestNum = x => x.Min();

            Console.WriteLine(getSmallestNum(nums));
        }
    }
}
