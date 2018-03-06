using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"([\w\W]*)=([\w\W]*)";

            var pattern = @"[?&]";

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] splitted = Regex.Split(input, pattern);

                var dict = new Dictionary<string, List<string>>();

                foreach (string s in splitted)
                {
                    MatchCollection matches = Regex.Matches(s, regex);

                    foreach (Match match in matches)
                    {
                        var field = match.Groups[1].Value;
                        var value = match.Groups[2].Value;

                        string spacePattern = "%20";
                        string plusPattern = "\\+";
                        string replacement = " ";

                        Regex rgxSpace = new Regex(spacePattern);
                        Regex rgxPlus = new Regex(plusPattern);

                        field = rgxSpace.Replace(field, replacement);
                        field = rgxPlus.Replace(field, replacement);

                        value = rgxSpace.Replace(value, replacement);
                        value = rgxPlus.Replace(value, replacement);
                        field = field.Trim();
                        value = value.Trim();
                        string[] values = value.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                        if (!dict.ContainsKey(field))
                        {
                            var newList = new List<string>();

                            newList.Add(string.Join(" ", values));

                            dict.Add(field, newList);
                        }
                        else
                        {
                            if (value != string.Empty)
                            {
                                dict[field].Add(string.Join(" ", values));
                            }
                        }
                    }
                }

                foreach (var pair in dict)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
            }
        }
    }
}