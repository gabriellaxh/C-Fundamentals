using System;

namespace _11.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split();
            string fullName = line1[0] + " " + line1[1];
            string address = line1[2];
            var tuple1 = new Tuple<string, string>(fullName, address);


            var line2 = Console.ReadLine().Split();
            string name = line2[0];
            int beers = int.Parse(line2[1]);
            var tuple2 = new Tuple<string, int>(name, beers);

            var line3 = Console.ReadLine().Split();
            int integer = int.Parse(line3[0]);
            double double_ = double.Parse(line3[1]);
            var tuple3 = new Tuple<int, double>(integer, double_);

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
