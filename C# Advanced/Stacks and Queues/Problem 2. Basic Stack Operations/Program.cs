using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Basic_Stack_Operations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var toPush = int.Parse(input[0]);
            var toPop = int.Parse(input[1]);
            var toCheck = int.Parse(input[2]);

            var array = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();

            var stack = new Stack<string>(array);

            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }
            foreach (var item in stack)
            {
                if(item == toCheck.ToString())
                {
                    Console.WriteLine("true");
                    return;
                }
            }
            if(stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(stack.Min());
            return;
        }
    }
}
