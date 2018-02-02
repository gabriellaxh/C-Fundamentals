using BashSoft;
using System;

namespace SimpleJudge
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tester.CompareContent(@"C:\Users\Gabriela\Downloads\BashSoft-Resources\actual.txt", @"C:\Users\Gabriela\Downloads\BashSoft-Resources\expected.txt");
            //Tester.CompareContent(@"C:\Users\Gabriela\Downloads\BashSoft-Resources\test2.txt", @"C:\Users\Gabriela\Downloads\BashSoft-Resources\test3.txt");
            
           // StudentsRepository.InitializeData(@"C:\Users\Gabriela\source\repos\C# Fundamentals\BashSoft\SimpleJudge\dataNew.txt");
            InputReader.StartReadingCommands();
        }
    }
}
