using System;
using System.Linq;

namespace _3._Group_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            var sizes = new int[3];
            var offsets = new int[3];
            
            //calculates how many nums have reminder 0/1/2
            foreach (var num in nums)
            {
                var reminder = Math.Abs(num % 3);

                sizes[reminder]++;
            }
            int reminderZero = sizes[0];
            int reminderOne = sizes[1];
            int reminderTwo = sizes[2];

            //initializes the jugged array's columns
            var numsMatrix = new int[3][]
            {
                new int[reminderZero],
                new int[reminderOne],
                new int[reminderTwo]
            };

            foreach (var number in nums)
            {
                int reminder = Math.Abs(number % 3);
                //index stores the column index where i've last put a num
                int index = offsets[reminder];
                numsMatrix[reminder][index] = number;
                offsets[reminder]++;
            }
            for (int row = 0; row < numsMatrix.GetLength(0); row++)
            {
                foreach (var num in numsMatrix[row])
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
