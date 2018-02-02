using System;
using System.IO;

namespace Problem_2._Line_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("text.txt"))
            {
                int lineNum = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNum++;
                    Console.WriteLine($"Line {lineNum}: {line}");
                    line = reader.ReadLine();
                }
            }
        }
    }
}
