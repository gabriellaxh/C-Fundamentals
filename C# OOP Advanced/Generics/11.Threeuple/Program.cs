using System;

namespace _11.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split();
            string fullName = line1[0] + " " + line1[1];
            string address = line1[2];
            string town = line1[3];
            var tuple1 = new Threeuple<string, string, string>(fullName, address, town);


            var line2 = Console.ReadLine().Split();
            string name = line2[0];
            int beers = int.Parse(line2[1]);
            string mood = line2[2];
            if (mood == "drunk")
                mood = "True";

            else
                mood = "False";
            var tuple2 = new Threeuple<string, int, string>(name, beers, mood);

            var line3 = Console.ReadLine().Split();
            string name_ = line3[0];
            double bankAccount = double.Parse(line3[1]);
            string bankName = line3[2];
            var tuple3 = new Threeuple<string, double, string>(name_, bankAccount, bankName);

            Console.WriteLine(tuple1.ToString());
            Console.WriteLine(tuple2.ToString());
            Console.WriteLine(tuple3.ToString());
        }
    }
}
