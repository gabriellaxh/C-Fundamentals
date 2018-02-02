using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            var rows = int.Parse(nums[0]);
            var cols = int.Parse(nums[1]);
            
            var sum = 0;
            
            var matrix = new int[rows, cols];
            
            for (int row = 0; row < rows; row++)
            {
                var numsArr = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numsArr[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
