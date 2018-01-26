using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char charr = input[i];
                if (charr == '(')
                {
                    stack.Push(i);
                }
                else if(charr == ')')
                {
                    var startIndex = stack.Pop();
                    var content = input.Substring(startIndex, i - startIndex + 1);

                    Console.WriteLine(content);
                }
            }

        }
    }
}
