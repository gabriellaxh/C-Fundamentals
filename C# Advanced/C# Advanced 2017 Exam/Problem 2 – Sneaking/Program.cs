using System;
using System.Linq;

namespace _02._Sneaking
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var matrix = new char[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }
            var commnads = Console.ReadLine().ToCharArray();


            ExecuteSamMoves(matrix, commnads);

        }

        private static void ExecuteSamMoves(char[][] matrix, char[] commands)
        {
            int samRow = FindSam(matrix)[0];
            int samCol = FindSam(matrix)[1];
            int nikoRow = FindNikoladze(matrix)[0];
            int nikoCol = FindNikoladze(matrix)[1];

            MoveEnemies(matrix, samRow, samCol);

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'U':
                        if (matrix[samRow - 1][samCol] == 'b' || matrix[samRow - 1][samCol] == 'd' || matrix[samRow - 1][samCol] == '.')
                        {
                            matrix[samRow][samCol] = '.';
                            matrix[samRow - 1][samCol] = 'S';
                            samRow = samRow - 1;
                        }
                        if (samRow == nikoRow)
                        {
                            matrix[nikoRow][nikoCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        MoveEnemies(matrix, samRow, samCol);
                        if (matrix[samRow][samCol] == 'X')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        break;

                    case 'D':
                        if (matrix[samRow + 1][samCol] == 'b' || matrix[samRow + 1][samCol] == 'd' || matrix[samRow + 1][samCol] == '.')
                        {
                            matrix[samRow][samCol] = '.';
                            matrix[samRow + 1][samCol] = 'S';
                            samRow = samRow + 1;
                        }
                        if (samRow == nikoRow)
                        {
                            matrix[nikoRow][nikoCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        MoveEnemies(matrix, samRow, samCol);
                        if (matrix[samRow][samCol] == 'X')
                        {
                            return;
                        }
                        break;

                    case 'R':
                        if (matrix[samRow][samCol + 1] == 'b' || matrix[samRow][samCol + 1] == 'd' || matrix[samRow][samCol + 1] == '.')
                        {
                            matrix[samRow][samCol] = '.';
                            matrix[samRow][samCol + 1] = 'S';
                            samCol = samCol + 1;
                        }
                        if (samRow == nikoRow)
                        {
                            matrix[nikoRow][nikoCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        MoveEnemies(matrix, samRow, samCol);
                        if (matrix[samRow][samCol] == 'X')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        break;

                    case 'L':
                        if (matrix[samRow][samCol - 1] == 'b' || matrix[samRow][samCol - 1] == 'd' || matrix[samRow][samCol - 1] == '.')
                        {
                            matrix[samRow][samCol] = '.';
                            matrix[samRow][samCol - 1] = 'S';
                            samCol = samCol - 1;
                        }
                        if (samRow == nikoRow)
                        {
                            matrix[nikoRow][nikoCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        MoveEnemies(matrix, samRow, samCol);
                        if (matrix[samRow][samCol] == 'X')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        break;

                    case 'W':
                        MoveEnemies(matrix, samRow, samCol);
                        if (matrix[samRow][samCol] == 'X')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    Console.Write(matrix[row][col]);
                                }
                                Console.WriteLine();
                            }
                            return;
                        }
                        break;
                }
            }


        }


        private static void MoveEnemies(char[][] matrix, int samRow, int samCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'b' && col < matrix[row].Length - 1)
                    {
                        matrix[row][col] = '.';

                        if (row == samRow && samCol >= col)
                        {
                            matrix[samRow][samCol] = 'X';
                            Console.WriteLine($"Sam died at {samRow}, {samCol}");
                            return;
                        }

                        matrix[row][col + 1] = 'b';
                        col++;
                    }

                    else if (matrix[row][col] == 'b' && col == matrix[row].Length - 1)
                    {
                        matrix[row][col] = 'd';
                        if (row == samRow && samCol <= col)
                        {
                            matrix[samRow][samCol] = 'X';
                            Console.WriteLine($"Sam died at {samRow}, {samCol}");
                            return;
                        }
                    }

                    if (matrix[row][col] == 'd' && col > 0)
                    {
                        matrix[row][col] = '.';
                        if (row == samRow && samCol <= col)
                        {
                            matrix[samRow][samCol] = 'X';
                            Console.WriteLine($"Sam died at {samRow}, {samCol}");
                            return;
                        }

                        matrix[row][col - 1] = 'd';
                    }

                    else if (matrix[row][col] == 'd' && col == 0)
                    {
                        matrix[row][col] = 'b';
                        if (row == samRow && samCol >= col)
                        {
                            matrix[samRow][samCol] = 'X';
                            Console.WriteLine($"Sam died at {samRow}, {samCol}");
                            return;
                        }
                    }
                }
            }
        }

        private static int[] FindNikoladze(char[][] matrix)
        {
            int[] nikoRowCol = new int[2];
            int rows = matrix.GetLength(0);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'N')
                    {
                        nikoRowCol[0] = row;
                        nikoRowCol[1] = col;
                    }
                }
            }
            return nikoRowCol;
        }

        private static int[] FindSam(char[][] matrix)
        {
            int[] samRowCol = new int[2];

            int rows = matrix.GetLength(0);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'S')
                    {
                        samRowCol[0] = row;
                        samRowCol[1] = col;
                        break;
                    }
                }
            }
            return samRowCol;
        }

    }
}
