using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8._Radioactive_Mutant_Vampire_Bunnies
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToArray();

            int rows = nums[0];
            int cols = nums[1];

            GetLair(rows, cols);
        }
        private static void GetLair(int rows, int cols)
        {
            string result = string.Empty;
            var jaggedArray = new char[rows][];
            int row = -1;
            int col = -1;

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Trim().ToCharArray();
            }
            var commands = Console.ReadLine().ToCharArray();
            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'U':
                        if (row != -1 && col != -1)
                        {
                            if (row - 1 < 0)
                            {
                                result = $"won: {row} {col}";
                                jaggedArray[row][col] = '.';
                                break;
                            }
                            else if (jaggedArray[row - 1][col] == 'B')
                            {
                                result = $"dead: {row - 1} {col}";
                                jaggedArray[row][col] = 'B';
                                break;
                            }
                            jaggedArray[row][col] = '.';
                            jaggedArray[row - 1][col] = 'P';
                            row = row - 1;

                            break;
                        }
                        else
                        {
                            for (int r = 0; r < rows; r++)
                            {
                                for (int c = 0; c < cols; c++)
                                {
                                    if (jaggedArray[r][c] == 'P')
                                    {
                                        if (r - 1 < 0)
                                        {
                                            result = $"won: {row} {col}";
                                            jaggedArray[row][col] = '.';
                                            break;
                                        }
                                        else if (jaggedArray[r - 1][c] == 'B')
                                        {
                                            result = $"dead: {row - 1} {col}";
                                            jaggedArray[row][col] = 'B';
                                            break;
                                        }
                                        jaggedArray[r][c] = '.';
                                        jaggedArray[r - 1][c] = 'P';
                                        row = r - 1;
                                        col = c;

                                        break;
                                    }
                                }
                            }
                        }
                        break;

                    case 'L':
                        if (row != -1 && col != -1)
                        {
                            if (col - 1 < 0)
                            {
                                result = $"won: {row} {col}";
                                jaggedArray[row][col] = '.';
                                break;
                            }
                            else if (jaggedArray[row][col - 1] == 'B')
                            {
                                result = $"dead: {row} {col - 1}";
                                jaggedArray[row][col] = 'B';
                                break;
                            }
                            jaggedArray[row][col] = '.';
                            jaggedArray[row][col - 1] = 'P';
                            col = col - 1;

                            break;
                        }
                        else
                        {
                            for (int r = 0; r < rows; r++)
                            {
                                for (int c = 0; c < cols; c++)
                                {
                                    if (jaggedArray[r][c] == 'P')
                                    {
                                        if (c - 1 < 0)
                                        {
                                            result = $"won: {row} {col}";
                                            jaggedArray[r][r] = '.';
                                            break;
                                        }
                                        else if (jaggedArray[r][c - 1] == 'B')
                                        {
                                            result = $"dead: {row} {col - 1}";
                                            jaggedArray[r][r] = 'B';
                                            break;
                                        }
                                        jaggedArray[r][c] = '.';
                                        jaggedArray[r][c - 1] = 'P';
                                        row = r;
                                        col = c - 1;

                                        break;
                                    }
                                }
                            }
                        }
                        break;

                    case 'D':
                        if (row != -1 && col != -1)
                        {
                            if (row + 1 > rows - 1)
                            {
                                result = $"won: {row} {col}";
                                jaggedArray[row][col] = '.';
                                break;
                            }
                            else if (jaggedArray[row + 1][col] == 'B')
                            {
                                result = $"dead: {row + 1} {col}";
                                jaggedArray[row][col] = 'B';
                                break;
                            }
                            jaggedArray[row][col] = '.';
                            jaggedArray[row + 1][col] = 'P';
                            row = row + 1;

                            break;
                        }
                        else
                        {
                            for (int r = 0; r < rows; r++)
                            {
                                for (int c = 0; c < cols; c++)
                                {
                                    if (jaggedArray[r][c] == 'P')
                                    {
                                        if (r + 1 < 0)
                                        {
                                            result = $"won: {row} {col}";
                                            jaggedArray[row][col] = '.';
                                            break;
                                        }
                                        else if (jaggedArray[r + 1][c] == 'B')
                                        {
                                            result = $"dead: {row + 1} {col}";
                                            jaggedArray[row][col] = 'B';
                                            break;
                                        }
                                        jaggedArray[r][c] = '.';
                                        jaggedArray[r + 1][c] = 'P';
                                        row = r + 1;
                                        col = c;

                                        break;
                                    }
                                }
                            }
                        }
                        break;

                    case 'R':
                        if (row != -1 && col != -1)
                        {
                            if (col + 1 < 0)
                            {
                                result = $"won: {row} {col}";
                                jaggedArray[row][col] = '.';
                                break;
                            }
                            else if (jaggedArray[row][col + 1] == 'B')
                            {
                                result = $"dead: {row} {col + 1}";
                                jaggedArray[row][col] = 'B';
                                break;
                            }
                            jaggedArray[row][col] = '.';
                            jaggedArray[row][col + 1] = 'P';
                            col = col + 1;

                            break;
                        }
                        else
                        {
                            for (int r = 0; r < rows; r++)
                            {
                                for (int c = 0; c < cols; c++)
                                {
                                    if (jaggedArray[r][c] == 'P')
                                    {
                                        if (c + 1 < 0)
                                        {
                                            result = $"won: {row} {col}";
                                            jaggedArray[row][col] = '.';
                                            break;
                                        }
                                        else if (jaggedArray[r][c + 1] == 'B')
                                        {
                                            result = $"dead: {row} {col + 1}";
                                            jaggedArray[row][col] = 'B';
                                            break;
                                        }
                                        jaggedArray[r][c] = '.';
                                        jaggedArray[r][c + 1] = 'P';
                                        row = r;
                                        col = c + 1;
                                        break;
                                    }
                                }
                            }
                        }
                        break;

                }
                MultiplyRabbits(jaggedArray, rows, cols);
            }
            PrintMatrix(jaggedArray, result);
        }

        private static void MultiplyRabbits(char[][] jaggedArray, int rows, int cols)
        {
            var jaggedArrCopy = new char[rows][];
            for (int row = 0; row < rows; row++)
            {
                jaggedArrCopy[row] = new char[cols];
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (jaggedArray[row][col] == 'B')
                    {
                        if (row == 0 || row == rows - 1)
                        {
                            if (row == 0)
                            {
                                if (col == 0)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row][col + 1] = 'B';
                                    jaggedArrCopy[row + 1][col] = 'B';
                                }
                                else if (col == cols - 1)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row][col - 1] = 'B';
                                    jaggedArrCopy[row + 1][col] = 'B';
                                }
                                else
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row][col + 1] = 'B';
                                    jaggedArrCopy[row][col - 1] = 'B';
                                    jaggedArrCopy[row + 1][col] = 'B';
                                }

                            }
                            else
                            {
                                if (col == 0)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row - 1][col] = 'B';
                                    jaggedArrCopy[row][col + 1] = 'B';
                                }
                                else if (col == cols - 1)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row][col - 1] = 'B';
                                    jaggedArrCopy[row - 1][col] = 'B';
                                }
                                else
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row - 1][col] = 'B';
                                    jaggedArrCopy[row][col + 1] = 'B';
                                    jaggedArrCopy[row][col - 1] = 'B';
                                }
                            }
                        }
                        else if (col == 0 || col == cols - 1)
                        {
                            if (col == 0)
                            {
                                if (row == 0)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row + 1][col] = 'B';
                                    jaggedArrCopy[row][col + 1] = 'B';

                                }
                                else if (row == rows - 1)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row - 1][col] = 'B';
                                    jaggedArrCopy[row][col + 1] = 'B';
                                }
                                else
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row - 1][col] = 'B';
                                    jaggedArrCopy[row][col + 1] = 'B';
                                    jaggedArrCopy[row + 1][col] = 'B';
                                }
                            }
                            else
                            {
                                if (row == 0)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row][col - 1] = 'B';
                                    jaggedArrCopy[row + 1][col] = 'B';
                                }
                                else if (row == rows - 1)
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row][col - 1] = 'B';
                                    jaggedArrCopy[row - 1][col] = 'B';
                                }
                                else
                                {
                                    jaggedArrCopy[row][col] = 'B';
                                    jaggedArrCopy[row - 1][col] = 'B';
                                    jaggedArrCopy[row][col - 1] = 'B';
                                    jaggedArrCopy[row + 1][col] = 'B';
                                }
                            }
                        }
                        else
                        {
                            jaggedArrCopy[row][col] = 'B';
                            jaggedArrCopy[row - 1][col] = 'B';
                            jaggedArrCopy[row][col + 1] = 'B';
                            jaggedArrCopy[row][col - 1] = 'B';
                            jaggedArrCopy[row + 1][col] = 'B';
                        }
                    }
                }

            }
            jaggedArray = jaggedArrCopy;
        }

        private static void PrintMatrix(char[][] jaggedArray, string message)
        {
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join("", row));
            }
            Console.WriteLine(message);
        }
    }
}
