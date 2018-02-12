using System;

namespace Problem_2___Knight_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var chessBoard = new char[size][];

            for (int row = 0; row < size; row++)
            {
                chessBoard[row] = Console.ReadLine().ToCharArray();
            }


            int rowToRemove = 0;
            int colToRemove = 0;
            int maxAttackedPositions = 0;
            int deadKnights = 0;
            do
            {
                if (maxAttackedPositions > 0)
                {
                    chessBoard[rowToRemove][colToRemove] = '0';
                    maxAttackedPositions = 0;
                    deadKnights++;
                }
                int currentAttackedPositions = 0;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (chessBoard[row][col] == 'K')
                        {
                            currentAttackedPositions = CalculatePossibleAttack(row, col, chessBoard, size);
                            if (currentAttackedPositions > maxAttackedPositions)
                            {
                                maxAttackedPositions = currentAttackedPositions;
                                rowToRemove = row;
                                colToRemove = col;
                            }
                        }
                    }
                }
            }
            while (maxAttackedPositions > 0);

            Console.WriteLine(deadKnights);
        }

        private static int CalculatePossibleAttack(int row, int col, char[][] chessBoard, int size)
        {
            var currentAttackedPositions = 0;
            if (isItPossibleToBeAttacked(row - 2, col - 1, size, chessBoard)) currentAttackedPositions++;
            if (isItPossibleToBeAttacked(row - 2, col + 1, size, chessBoard)) currentAttackedPositions++;
            if (isItPossibleToBeAttacked(row + 2, col + 1, size, chessBoard)) currentAttackedPositions++;
            if (isItPossibleToBeAttacked(row + 2, col - 1, size, chessBoard)) currentAttackedPositions++;
            if (isItPossibleToBeAttacked(row + 1, col - 2, size, chessBoard)) currentAttackedPositions++;
            if (isItPossibleToBeAttacked(row + 1, col + 2, size, chessBoard)) currentAttackedPositions++;
            if (isItPossibleToBeAttacked(row - 1, col - 2, size, chessBoard)) currentAttackedPositions++;
            if (isItPossibleToBeAttacked(row - 1, col + 2, size, chessBoard)) currentAttackedPositions++;

            return currentAttackedPositions;

        }
        static bool isItPossibleToBeAttacked(int row, int col, int size, char[][] chessBoard)
        {
            return row >= 0 && row < size &&
                   col >= 0 && col < size &&
                   chessBoard[row][col] == 'K';
        }
    }
}
