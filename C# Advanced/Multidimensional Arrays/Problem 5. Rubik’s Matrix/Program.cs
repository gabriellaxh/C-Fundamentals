using System;
using System.Linq;

namespace Problem_5._Rubik_s_Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = nums[0];
            int cols = nums[1];

            var matrix = new int[rows, cols];
            var num = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = num;
                    num++;
                }
            }
            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                var command = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var direction = command[1];

                switch (direction)
                {
                    case "down":
                        var colDown = int.Parse(command[0]);
                        var movesDown = int.Parse(command[2]);
                        for (int time = 0; time < movesDown; time++)
                        {
                            var n = matrix[0, colDown];
                            for (int row = 1; row < rows; row++)
                            {
                                var second = matrix[row, colDown];
                                matrix[row, colDown] = n;
                                n = second;
                            }
                            matrix[0, colDown] = n;
                        }
                        break;

                    case "up":
                        var colUp = int.Parse(command[0]);
                        var movesUp = int.Parse(command[2]);
                        for (int time = 0; time < movesUp; time++)
                        {
                            var n = matrix[0, colUp];
                            for (int row = cols - 1; row > 0; row--)
                            {
                                var second = matrix[row, colUp];
                                matrix[row, colUp] = n;
                                n = second;
                            }
                            matrix[0, colUp] = n;
                        }
                        break;

                    case "left":
                        var rowLeft = int.Parse(command[0]);
                        var movesLeft = int.Parse(command[2]);
                        for (int time = 0; time < movesLeft; time++)
                        {
                            var n = matrix[rowLeft, 0];
                            for (int col = cols - 1; col > 0; col--)
                            {
                                var second = matrix[rowLeft, col];
                                matrix[rowLeft, col] = n;
                                n = second;
                            }
                            matrix[rowLeft, 0] = n;
                        }
                        break;

                    case "right":
                        var rowRight = int.Parse(command[0]);
                        var movesRight = int.Parse(command[2]);
                        for (int time = 0; time < movesRight; time++)
                        {
                            var n = matrix[rowRight, 0];
                            for (int col = 1; col < rows; col++)
                            {
                                var second = matrix[rowRight, col];
                                matrix[rowRight, col] = n;
                                n = second;
                            }
                            matrix[rowRight, 0] = n;
                        }
                        break;
                }
            }
            RearrangeRubik(matrix);
        }
        public static void RearrangeRubik(int[,] matrix)
        {
            var digit = 1;
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            int swapW = 0;
            int swapH = 0;
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    if (matrix[row, col] == digit)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        if (matrix[row, col] != digit && digit == 1)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = col; c < height; c++)
                                {
                                    if (matrix[r, c] == 1)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 2)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = 0; c < height; c++)
                                {
                                    if (matrix[r, c] == 2)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }

                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 3)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = col; c < height; c++)
                                {
                                    if (matrix[r, c] == 3)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 4)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = col; c < height; c++)
                                {
                                    if (matrix[r, c] == 4)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 5)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = col; c < height; c++)
                                {
                                    if (matrix[r, c] == 5)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 6)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c =1; c < height; c++)
                                {
                                    if (matrix[r, c] == 6)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 7)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = col; c < height; c++)
                                {
                                    if (matrix[r, c] == 7)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 8)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = col; c < height; c++)
                                {
                                    if (matrix[r, c] == 8)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                        else if (matrix[row, col] != digit && digit == 9)
                        {
                            for (int r = row; r < width; r++)
                            {
                                for (int c = col; c < height; c++)
                                {
                                    if (matrix[r, c] == 9)
                                    {
                                        swapW = r;
                                        swapH = c;
                                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                        var m = matrix[row, col];
                                        matrix[row, col] = matrix[r, c];
                                        matrix[r, c] = m;
                                    }
                                }
                            }
                        }
                    }
                    digit++;
                }
            }
        }
    }
}


