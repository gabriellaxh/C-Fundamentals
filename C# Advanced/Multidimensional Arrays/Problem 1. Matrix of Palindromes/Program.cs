using System;
using System.Linq;

namespace Problem_1._Matrix_of_Palindromes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var params_ = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = params_[0];
            int cols = params_[1];
            int depth = 3;

            var matrix = new string[rows, cols, depth];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col, 0] = alphabet[row];
                    matrix[row, col, 2] = alphabet[row];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                var c = row;
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col, 1] = alphabet[c];
                    c++;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    for (int dep = 0; dep < depth; dep++)
                    {
                        Console.Write(matrix[row, col, dep]);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
