using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication292
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = "([A-Za-z]+)(.+)(\\1)";

            var input = Console.ReadLine();

            List<string> inputPlaceholders = Console.ReadLine()
                .Split(new[] {'{', '}'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            MatchCollection matches = Regex.Matches(input, regex);

            string result = input;

            int min = matches.Count < inputPlaceholders.Count ? matches.Count : inputPlaceholders.Count;
         
            for (int i = 0; i < min; i++)
            {
                string pattern = matches[i].Groups[2].Value;

                string Replacement = inputPlaceholders[i];

                result = result.Replace(matches[i].Value, matches[i].Value.Replace(pattern,Replacement));
            }

            Console.WriteLine(result);
        }
    }
}