using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(' ');
            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                var _operator = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                switch (_operator)
                {
                    case "+":
                        stack.Push((firstNum + secondNum).ToString());
                        break;
                    case "-":
                        stack.Push((firstNum - secondNum).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
