using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Reverse_Numbers_with_a_Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var stack = new Stack<int>();

            foreach (var item in input)
            {
                stack.Push(int.Parse(item));
            }
            while(stack.Count != 0)
            { 
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
