using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var regex = @"(\S.+?[.!?])(?=\s+|$)";

            var NestedRegex = @"(?:^|\W)" + word + @"(?:$|\W)";

            var input = Console.ReadLine();

            MatchCollection sentences = Regex.Matches(input, regex);

            foreach (Match sentence in sentences)
            {
                bool isMathched = Regex.IsMatch(sentence.Value, NestedRegex);

                if (isMathched)
                {
                    Console.WriteLine(sentence.Value.Remove(sentence.Value.Length - 1));
                }
            }
        }
    }
}