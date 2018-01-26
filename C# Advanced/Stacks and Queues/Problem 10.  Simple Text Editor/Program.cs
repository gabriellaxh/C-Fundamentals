using System;
using System.Collections.Generic;

namespace Problem_10.__Simple_Text_Editor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
          
            var lastText = new Stack<string>();
            var text = string.Empty;


            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "1":
                        lastText.Push(text);
                        text += input[1];
                        break;

                    case "2":
                        lastText.Push(text);
                        var countToRemove = int.Parse(input[1]);
                        text = text.Substring(0, text.Length - countToRemove);
                        break;
                    case "3":
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case "4":
                        text = lastText.Pop();
                        break;
                }
            }
        }
    }
}
