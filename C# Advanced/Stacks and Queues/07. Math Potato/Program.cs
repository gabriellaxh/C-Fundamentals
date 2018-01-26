using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Potato
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            int count = 0;

            var queue = new Queue<string>();

            while (input != "end")
            {
                if (input == "green")
                {
                    if (queue.Count == 0)
                    {
                        break;
                    }
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count += 1;
                        if(queue.Count == 0)
                        {
                            break;
                        }
                    }
                    input = Console.ReadLine();
                }

                else
                {
                    queue.Enqueue(input);
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
            return;
        }
    }
}
