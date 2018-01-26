using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem_5._Calculate_Sequence_with_Queue
{
    public class Program
    {
        static void Main(string[] args)

        {
            var num = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(num);

            var currentNum = new Queue<long>();

            while(queue.Count < 50)
            {
                queue.Enqueue(num + 1);
                currentNum.Enqueue(num + 1);

                if(queue.Count < 50)
                {
                    queue.Enqueue(2 * num + 1);
                    currentNum.Enqueue(2 * num + 1);
                }

                if(queue.Count < 50)
                {
                    queue.Enqueue(num + 2);
                    currentNum.Enqueue(num + 2);
                    num = currentNum.Dequeue();
                }
            }
            Console.WriteLine(string.Join(" ",queue));
        }
    }
}
