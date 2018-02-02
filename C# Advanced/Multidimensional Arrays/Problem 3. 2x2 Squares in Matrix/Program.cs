using System;
using System.Linq;

namespace Problem_3._2x2_Squares_in_Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = nums[0];
            int cols = nums[1];

            var matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            var count = 0;
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if(matrix[row,col] == matrix[row,col+1] && matrix[row,col+1] == matrix[row+1,col] && matrix[row+1,col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
