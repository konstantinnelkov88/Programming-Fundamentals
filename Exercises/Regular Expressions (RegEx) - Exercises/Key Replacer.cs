using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"([a-zA-Z]+)[<\|\\].*[<\|\\]([a-zA-Z]+)";

            var result = new StringBuilder();
            var start = string.Empty;
            var end = string.Empty;

            var input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (Regex.IsMatch(input1, regex))
            {
                var keystring = Regex.Match(input1, regex);

                start = keystring.Groups[1].Value;

                end = keystring.Groups[2].Value;

                var textPattern = start + @"(?<word>.*?){1}" + end;
                var matches = Regex.Matches(input2, textPattern);

                foreach (Match match in matches)
                {
                    result.Append(match.Groups["word"].Value);
                }

                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}