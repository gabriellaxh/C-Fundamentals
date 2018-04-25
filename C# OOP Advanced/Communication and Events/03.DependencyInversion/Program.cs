using P03_DependencyInversion;
using System;

namespace _03.DependencyInversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator calc = new PrimitiveCalculator();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                var info = input.Split();

                if (info[0] == "mode")
                {
                    calc.ChangeStrategy(char.Parse(info[1]));
                    continue;
                }

                int num1 = int.Parse(info[0]);
                int num2 = int.Parse(info[1]);
                

                Console.WriteLine(calc.PerformCalculation(num1,num2));
            }
        }
    }
}
