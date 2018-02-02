using System;
using System.Linq;

namespace Problem_4._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = nums[0];
            int cols = nums[1];

            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int bestSum = int.MinValue;
            var first = 0;
            var second = 0;
            var third = 0;
            var fourth = 0;
            var fifth = 0;
            var sixth = 0;
            var seventh = 0;
            var eighth = 0;
            var ninth = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    var sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        first = matrix[row, col];
                        second = matrix[row, col + 1];
                        third = matrix[row, col + 2];
                        fourth = matrix[row + 1, col];
                        fifth = matrix[row + 1, col + 1];
                        sixth = matrix[row + 1, col + 2];
                        seventh = matrix[row + 2, col];
                        eighth = matrix[row + 2, col + 1];
                        ninth = matrix[row + 2, col + 2];
                    }
                }
            }
            Console.WriteLine("Sum = " + bestSum);
            Console.Write(first + " " + second + " " + third);
            Console.WriteLine();
            Console.Write(fourth + " " + fifth + " " + sixth);
            Console.WriteLine();
            Console.Write(seventh + " " + eighth + " " + ninth);
            Console.WriteLine();
        }
    }
}
