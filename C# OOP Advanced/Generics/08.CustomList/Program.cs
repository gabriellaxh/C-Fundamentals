﻿using System;

namespace _08.CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] info = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (info[0])
                {
                    case "Add":
                        customList.Add(info[1]);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(info[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(info[1]));
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(info[1]), int.Parse(info[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.Greater(info[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        customList.Print();
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
