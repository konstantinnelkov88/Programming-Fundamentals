using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            var regex = @"<p>(.*?)<\/p>";

            var input = Console.ReadLine();
            string result = string.Empty;

            MatchCollection matches = Regex.Matches(input, regex);

            string currentText = string.Empty;

            if (Regex.IsMatch(input, regex))
            {
                StringBuilder currentResult = new StringBuilder();
                foreach (Match match in matches)
                {
                    currentText = match.Groups[1].Value;

                    string replacement = " ";

                    string Pattern = "([^a-z0-9])";

                    Regex rgx = new Regex(Pattern);

                    currentText = rgx.Replace(currentText, replacement);

                    
                    foreach (char c in currentText)
                    {
                        int ascii = (int)c;

                        if (c >= 'a' && c <= 'm')
                        {
                            ascii += 13;
                        }
                        else if (c >= 'n' && c <= 'z')
                        {
                            ascii -= 13;
                        }

                        currentResult.Append((char)ascii);
                    }
                }

                string[] final = currentResult
                    .ToString()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                result += string.Join(" ", final);
                Console.WriteLine(result);
            }
        }
    }
}