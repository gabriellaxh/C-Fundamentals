using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1___Dangerous_Floor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chessBoard = new char[8, 8];

            for (int row = 0; row < 8; row++)
            {
                var line = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(char.Parse)
                                         .ToArray();
                for (int col = 0; col < 8; col++)
                {
                    chessBoard[row, col] = line[col];
                }
            }

            StartReadingCommands(chessBoard);
        }

        private static void StartReadingCommands(char[,] chessBoard)
        {
            var command = Console.ReadLine();
            while (command != "END")
            {
                char pieceType = char.Parse(command.Substring(0, 1));

                var currentRow = int.Parse(command.Substring(1, 1));
                var currentCol = int.Parse(command.Substring(2, 1));

                var moveToRow = int.Parse(command.Substring(4, 1));
                var moveToCol = int.Parse(command.Substring(5, 1));



                if (currentRow > 8 || currentCol > 8 || chessBoard[currentRow, currentCol] != pieceType)
                {
                    Console.WriteLine("There is no such a piece!");
                }
                else if (moveToRow < 0 || moveToRow > 7 || moveToCol < 0 || moveToCol > 7)
                {
                    Console.WriteLine("Move go out of board!");
                }
                else
                {
                    switch (pieceType)
                    {
                        case 'K':
                            TryExecuteKingMove(currentRow, currentCol, moveToRow, moveToCol, chessBoard);
                            break;

                        case 'R':
                            TryExecuteRookMove(currentRow, currentCol, moveToRow, moveToCol, chessBoard);
                            break;

                        case 'B':
                            TryExecuteBishopMove(currentRow, currentCol, moveToRow, moveToCol, chessBoard);
                            break;

                        case 'Q':
                            TryExecuteQueenMove(currentRow, currentCol, moveToRow, moveToCol, chessBoard);
                            break;

                        case 'P':
                            TryExecutePawnMove(currentRow, currentCol, moveToRow, moveToCol, chessBoard);
                            break;
                    }
                }
                command = Console.ReadLine();
            }
        }

        private static void TryExecutePawnMove(int currentRow, int currentCol, int moveToRow, int moveToCol, char[,] chessBoard)
        {
            if (currentRow < 4 && moveToRow == currentRow + 1 && moveToCol == currentCol)
            {
                chessBoard[currentRow, currentCol] = 'x';
                chessBoard[moveToRow, moveToCol] = 'P';
            }
            else if (currentRow > 4 && moveToRow == currentRow - 1 && moveToCol == currentCol)
            {
                chessBoard[currentRow, currentCol] = 'x';
                chessBoard[moveToRow, moveToCol] = 'P';
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }
        }

        private static void TryExecuteQueenMove(int currentRow, int currentCol, int moveToRow, int moveToCol, char[,] chessBoard)
        {
            var right = currentCol;
            var left = currentCol;
            if (moveToRow > currentRow)
            {
                for (int row = currentRow; row < moveToRow; row++)
                {
                    right++;
                    left--;
                }
            }
            else
            {
                for (int row = currentRow; row > moveToRow; row--)
                {
                    right++;
                    left--;
                }
            }
;
            if (moveToRow != currentRow && moveToCol == currentCol ||
                moveToRow == currentRow && moveToCol != currentCol ||
                moveToRow != currentRow && moveToCol == right ||
                moveToRow != currentRow && moveToCol == left)
            {
                chessBoard[currentRow, currentCol] = 'x';
                chessBoard[moveToRow, moveToCol] = 'Q';
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }
        }

        private static void TryExecuteBishopMove(int currentRow, int currentCol, int moveToRow, int moveToCol, char[,] chessBoard)
        {
            var right = currentCol;
            var left = currentCol;
            if (moveToRow > currentRow)
            {
                for (int row = currentRow; row < moveToRow; row++)
                {
                    right++;
                    left--;
                }
            }
            else
            {
                for (int row = currentRow; row > moveToRow; row--)
                {
                    right++;
                    left--;
                }
            }

            if (moveToRow != currentRow && moveToCol == right ||
                moveToRow != currentRow && moveToCol == left)
            {
                chessBoard[currentRow, currentCol] = 'x';
                chessBoard[moveToRow, moveToCol] = 'B';
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }
        }

        private static void TryExecuteRookMove(int currentRow, int currentCol, int moveToRow, int moveToCol, char[,] chessBoard)
        {
            if (moveToRow == currentRow && moveToCol != currentCol ||
               moveToRow != currentRow && moveToCol == currentCol)
            {
                chessBoard[currentRow, currentCol] = 'x';
                chessBoard[moveToRow, moveToCol] = 'R';
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }
        }

        private static void TryExecuteKingMove(int currentRow, int currentCol, int moveToRow, int moveToCol, char[,] chessBoard)
        {
            if (moveToRow == currentRow && moveToCol == currentCol + 1 ||
               moveToRow == currentRow && moveToCol == currentCol - 1 ||
               moveToRow == currentRow + 1 && moveToCol == currentCol ||
               moveToRow == currentRow + 1 && moveToCol == currentCol ||
               moveToRow == currentRow + 1 && moveToCol == currentCol + 1 ||
               moveToRow == currentRow + 1 && moveToCol == currentCol - 1 ||
               moveToRow == currentRow - 1 && moveToCol == currentCol + 1 ||
               moveToRow == currentRow - 1 && moveToCol == currentCol - 1)
            {
                chessBoard[currentRow, currentCol] = 'x';
                chessBoard[moveToRow, moveToCol] = 'K';
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }
        }
    }
}
