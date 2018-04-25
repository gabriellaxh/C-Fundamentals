using System;
using System.Linq;

namespace Database
{
    public class DatabaseClass
    {
        private const int capacity = 16;

        private int[] integers;
        private int count;

        private DatabaseClass()
        {
            this.integers = new int[capacity];
            this.count = 0;
        }

        public DatabaseClass(params int[] nums)
            : this()
        {
            if (nums != null)
            {
                foreach (var num in nums)
                {
                    this.Add(num);
                }
            }
        }

        public void Add(int numToAdd)
        {
            if (this.integers.Length == this.count)
            {
                throw new InvalidOperationException("Cannot add more than 16 numbers!");
            }
            integers[this.count] = numToAdd;
            this.count++;
        }

        public void Remove()
        {
            if (this.count == 0)
                throw new InvalidOperationException("Count is null!");

            integers.SetValue(null, this.integers.Length - 1);
            this.count--;
        }

        public int[] Fetch()
        {
            return this.integers.ToArray();
        }
    }
}
