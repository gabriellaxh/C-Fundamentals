using System;
using System.Linq;

namespace Problem_13._TriFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, int> sumChars = x => x.ToCharArray().Sum(s => s);
            Func<string, int, bool> isLargerOrNot = (x, n) => sumChars(x) >= n;

            var theChosenName = names.FirstOrDefault(x => isLargerOrNot(x, num));
        }
    }
}
