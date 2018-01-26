using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Maximum_Element
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            var maxNums = new Stack<int>();
            var maxValue = 0;

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(input[0] == 1)
                {
                    stack.Push(input[1]);
                    if(maxValue < input[1])
                    {
                        maxValue = input[1];
                        maxNums.Push(maxValue);
                    }
                }

                if(input[0] == 2)
                {
                    if(stack.Count == 0)
                    {
                        continue;
                    }

                    if(stack.Pop() == maxValue)
                    {
                        maxNums.Pop();
                        if(maxNums.Count() != 0)
                        {
                            maxValue = maxNums.Peek();
                        }
                    }
                }

                if (input[0] == 3)
                {
                    if(stack.Count == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(maxNums.Max());
                    }
                }
            }
        }
    }
}
