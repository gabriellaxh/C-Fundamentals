using System;

namespace _4._Pascal_Triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var matrix = new long[num][];

            var count = 1;
            for (int row = 0; row < num; row++)
            {
                matrix[row] = new long[count];
                matrix[row][0] = 1;
                matrix[row][count - 1] = 1;
                count++;
                if (row >= 2)
                {
                    for (int col = 1; col < count - 2; col++)
                    {
                        matrix[row][col] = matrix[row - 1][col - 1] + matrix[row - 1][col];
                    }
                }
            }
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
