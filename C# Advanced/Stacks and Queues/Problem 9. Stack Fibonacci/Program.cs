using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem_9._Stack_Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fibonacciStack = new Stack<long>();
            fibonacciStack.Push(0);
            fibonacciStack.Push(1);

            for (int i = 2; i <= n; i++)
            {
                var first = fibonacciStack.Pop();
                var second = fibonacciStack.Peek();
                fibonacciStack.Push(first);
                fibonacciStack.Push(first + second);
            }
            Console.WriteLine(fibonacciStack.Peek());
        }
    }
}
