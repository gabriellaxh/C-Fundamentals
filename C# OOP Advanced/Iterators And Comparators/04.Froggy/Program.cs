using System;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake<int> lake = new Lake<int>(stones);

            
            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
