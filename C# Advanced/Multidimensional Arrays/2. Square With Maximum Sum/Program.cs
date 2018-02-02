using System;
using System.Linq;

namespace _2._Square_With_Maximum_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            var rows = nums[0];
            var cols = nums[1];


            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var numsArr = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numsArr[col];
                }
            }
            var bestSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    var sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
            Console.WriteLine(matrix[rowIndex, colIndex] + " " + matrix[rowIndex,colIndex+1] + " ");
            Console.WriteLine(matrix[rowIndex+1, colIndex] + " " + matrix[rowIndex+1, colIndex + 1] + " ");
            Console.WriteLine(bestSum);
        }
    }
}
