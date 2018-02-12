using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3___Crypto_Blockchain
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var regex = new Regex(@"[{\[].+?[}\]]");

            var stringBuilder = string.Empty;

            for (int i = 0; i < rows; i++)
            {
                stringBuilder += (Console.ReadLine());
            }
            var matches = regex.Matches(stringBuilder);
            foreach (Match match in matches)
            {
                string num = string.Empty;
                var matchChar = match.ToString().ToCharArray();
                for (int i = 0; i < match.Length; i++)
                {
                    if (char.IsDigit(matchChar[i]))
                    {
                        num += matchChar[i];
                    }
                }
                
                if(num.Length % 3 != 0)
                {
                    continue;
                }
                else
                {
                    var list = new List<string>();
                    for (int i = 0; i < num.Length; i+=3)
                    {
                        list.Add(num.Substring(i, 3));
                    }
                   
                    
                }
            }
        }
    }
}
