using System;
using System.Linq;

namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var command = input.Split().ToArray();

                try
                {
                    switch (command[0])
                    {
                        case "Push":
                            var row = command.Skip(1).ToList();
                            foreach (var item in row)
                            {
                                if (string.IsNullOrEmpty(item))
                                    break;

                                else
                                    stack.Push(item.Substring(0, 1));
                            }
                            break;

                        case "Pop":
                            stack.Pop();
                            break;
                    }
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
