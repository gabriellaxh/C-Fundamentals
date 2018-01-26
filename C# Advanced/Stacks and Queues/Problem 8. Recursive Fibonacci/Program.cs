using System;

namespace Problem_8._Recursive_Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(n));
        }

        private static long GetFibonacci(long n)
        {
            if (n < 3)
                return 1;
            long[] f = new long[n + 1];
            f[0] = 0;
            f[1] = 1;
            f[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n];

        }
    }
}
