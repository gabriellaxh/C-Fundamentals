using System;
using System.Linq;

namespace Problem_2._Diagonal_Difference
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var matrix = new int[num, num];
            for (int row = 0; row < num; row++)
            {
                var input = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < num; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int leftd = 0;
            int rightd = 0;
            for (int row = 0; row < num; row++)
            {
                leftd += matrix[row, row];
            }

            for (int i = 0; i < num; i++)
            {
                rightd += matrix[i, num-1-i];
            }
            Console.WriteLine(Math.Abs(leftd - rightd));
        }
    }
}
