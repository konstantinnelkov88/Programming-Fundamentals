using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {

            var regex = @"(?<![\w\-\.])[a-zA-Z0-9]([\w\.\-])+@[a-zA-Z]{1}[A-Za-z\-]+(\.[A-Za-z\-]+[a-zA-Z])+\b";

            var input = Console.ReadLine();

            MatchCollection emails = Regex.Matches(input, regex);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }

        }
    }
}