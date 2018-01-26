using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11.__Poisonous_Plants
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var plants = Console.ReadLine()
                                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
            var list = new List<int>();
            var indexes = new Stack<int>();
            var day = 0;

            foreach (var plant in plants)
            {
                list.Add(plant);
            }
            list.Reverse();
            bool ifTrue = true;

            while (ifTrue)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        indexes.Push(i);
                    }
                }

                int count = indexes.Count();
                if(count == 0)
                {
                    ifTrue = false;
                    break;
                }
                for (int i = 0; i < count; i++)
                {
                    list.RemoveAt(indexes.Pop());
                }
                day++;
            }
            Console.WriteLine(day);
        }
    }
}
