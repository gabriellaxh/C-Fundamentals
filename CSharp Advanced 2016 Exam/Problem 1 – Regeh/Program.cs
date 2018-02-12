using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_1___Regeh
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var text = input.ToCharArray();
            var regex = new Regex(@"\[(\w+)(<\d+REGEH\d+>)(\w+)]");
            var matches = regex.Matches(input);

            var result = string.Empty;
            var nums = "0";
            var oldNum = 0;
            foreach (var match in matches)
            {
                var charArr = match.ToString().ToArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '<' || charArr[i] == 'H')
                    {
                        oldNum += int.Parse(nums);
                        nums = "0";
                        for (int arr = i + 1; arr < charArr.Length; arr++)
                        {
                            if (charArr[arr] == '1' || charArr[arr] == '2' || charArr[arr] == '3' || charArr[arr] == '4' || charArr[arr] == '5' || charArr[arr] == '6' || charArr[arr] == '7' || charArr[arr] == '8' || charArr[arr] == '9' || charArr[arr] == '0')
                            {
                                nums += charArr[arr];
                            }
                            else
                            {
                                //int val = (int)Char.GetNumericValue(charArr[arr]);

                                int parsedNum = int.Parse(nums);
                                int value = parsedNum + oldNum;
                                if(value > text.Length)
                                {
                                    value = value %  text.Length + 1;
                                }
                                result += text.GetValue(value);
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
