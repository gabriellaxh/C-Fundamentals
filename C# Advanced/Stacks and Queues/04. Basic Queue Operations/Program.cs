using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    public class Program
    {
        static void Main(string[] args)

        {
            var nums = Console.ReadLine().Split();

            var toEnqueue = int.Parse(nums[0]);
            var toDequeue = int.Parse(nums[1]);
            var toFind = int.Parse(nums[2]);

            var array = Console.ReadLine().Split();

            var queue = new Queue<int>();
            for (int i = 0; i < toEnqueue; i++)
            {
                queue.Enqueue(int.Parse(array[i]));
            }
            for (int i = 0; i < toDequeue; i++)
            {
                queue.Dequeue();
            }
            foreach (var item in queue)
            {
                if (item == toFind)
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(queue.Min());
            return;
        }
    }
}