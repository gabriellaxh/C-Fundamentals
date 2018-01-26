using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem_7._Balanced_Parentheses
{
    public class Program
    {
        static void Main(string[] args)

        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var queue = new Queue<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;

            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == '{')
                {
                    stack.Push('}');

                }
                else if (input[i] == '[')
                {
                    stack.Push(']');
                }
                else if (input[i] == '(')
                {
                    stack.Push(')');
                }
                else if (input[i] == ' ')
                {
                    stack.Push(' ');
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
                queue.Enqueue(input[input.Length / 2 + i]);
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
            return;
        }
    }
}
