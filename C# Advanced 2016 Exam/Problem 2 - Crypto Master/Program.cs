using System;
using System.Linq;

namespace Problem_2___Crypto_Master
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            int maxCount = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                    for (int step = 1; step < numbers.Length; step++)
                    {
                    var currentIndex = index;
                    //forms endless circle
                    var nextIndex = (index + step) % numbers.Length;
                    var currentCount = 1;

                    while(numbers[currentIndex] < numbers[nextIndex])
                    {
                        currentIndex = nextIndex;
                        nextIndex = (currentIndex + step) % numbers.Length;
                        currentCount++;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
