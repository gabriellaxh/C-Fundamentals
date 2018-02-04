using System;

namespace Problem_2._Knights_of_Honor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Action<string> appendAndPrint = x => Console.WriteLine($"Sir {x}");

            foreach (var name in names)
            {
                appendAndPrint(name);
            }
        }
    }
}
