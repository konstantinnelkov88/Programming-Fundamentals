using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var splitted = input.Split(new char[] { '/', ' ', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < splitted.Count; i++)
            {
                if (splitted[i].Length < 3 || splitted[i].Length > 25 || char.IsDigit(splitted[i][0]))
                {
                    splitted.RemoveAt(i);
                }
            }

            int maxSum = 0;
            int first = 0;
            int second = 0;

            for (int i = 0; i < splitted.Count - 1; i++)
            {
                if (splitted[i].Length + splitted[i + 1].Length > maxSum)
                {
                    maxSum = splitted[i].Length + splitted[i + 1].Length;
                    first = i;
                    second = i + 1;
                }
            }
            Console.WriteLine(splitted[first]);
            Console.WriteLine(splitted[second]);
        }
    }
}