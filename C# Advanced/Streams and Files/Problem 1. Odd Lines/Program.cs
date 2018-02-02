using System;
using System.IO;

namespace Problem_1._Odd_Lines
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
                    if(lineNum % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    
                    line = reader.ReadLine();
                }
            }
        }
    }
}
