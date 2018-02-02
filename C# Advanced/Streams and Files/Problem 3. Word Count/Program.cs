using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3._Word_Count
{
    public class Program
    {
        static void Main(string[] args)
        {
            var wordCount = new Dictionary<string, int>();

            using (var reader = new StreamReader("words.txt"))
            {
                while (true)
                {
                    var word = reader.ReadLine();

                    if(word == null)
                    {
                        break;
                    }

                    word = word.ToLower();

                    if (!wordCount.ContainsKey(word))
                    {
                        wordCount[word] = 0;
                    }
                }
            }

            using(var reader = new StreamReader("text.txt"))
            {
                while (true)
                {
                    var line = reader.ReadLine();

                    if(line == null)
                    {
                        break;
                    }

                    var words = line.Split(" .,?!:;-[]{}()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => x.ToLower())
                                   .ToArray();

                    foreach (var word in words)
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                    }
                }
            }

            using (var writer = new StreamWriter("result.txt"))
            {
                var result = wordCount.OrderByDescending(x => x.Value)
                    .Select(x => $"{x.Key} - {x.Value}");

                foreach (var word in result)
                {
                    writer.WriteLine(word);
                    writer.Flush();
                }
            }
        }
    }
}
