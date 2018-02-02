using System;
using System.Linq;

namespace Problem_7._Lego_Blocks
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var jArr1 = GetMatrix(rows);
            var jArr2 = GetMatrix(rows);

            var totalCount = GetElementsCount(jArr1, jArr2);

            if (totalCount == 0)
            {
                var joinedArr = GetJoinedMartix(jArr1, jArr2, rows);
                foreach (var row in joinedArr)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalCount}");
            }

        }

        private static int[][] GetJoinedMartix(int[][] jArr1, int[][] jarr2, int rows)
        {
            var joinedArr = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                joinedArr[i] = jArr1[i].Concat(jarr2[i].Reverse()).ToArray();
            }
            return joinedArr;
        }

        private static int GetElementsCount(int[][] arr1, int[][] arr2)
        {
            bool doesItFit = true;

            var firstRowLen = arr1[0].Length + arr2[0].Length;

            int totalCount = firstRowLen;
            for (int i = 1; i < arr1.Length; i++)
            {
                var currentLen = arr1[i].Length + arr2[i].Length;
                totalCount += currentLen;

                if (currentLen != firstRowLen)
                {
                    doesItFit = false;
                }
            }

            if (doesItFit)
            {
                return 0;
            }

            return totalCount;
        }

        private static int[][] GetMatrix(int rows)
        {
            var jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(int.Parse)
                                                   .ToArray();

            }
            return jaggedArray;
        }


    }
}
