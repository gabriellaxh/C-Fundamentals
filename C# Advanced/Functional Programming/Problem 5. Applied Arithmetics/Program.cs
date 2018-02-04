using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Applied_Arithmetics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();

            ReadAndExecuteCommand(nums);
        }

        private static void ReadAndExecuteCommand(List<int> nums)
        {
            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x * 2;
            Func<int, int> substract = x => x - 1;

            var command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        nums = nums.Select(add).ToList();
                        break;

                    case "subtract":
                        nums = nums.Select(substract).ToList();
                        break;

                    case "multiply":
                        nums = nums.Select(multiply).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                }
                command = Console.ReadLine();
            }

        }
    }
}

