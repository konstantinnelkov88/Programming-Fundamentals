using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double totalsum = 0;

            foreach (var seq in input)
            {
                char firstLetter = seq.First();
                char lastLetter = seq.Last();
                var num = seq.Substring(1);
                num = num.Remove(num.Length - 1, 1);
                int number = int.Parse(num);
                double first = 0;
                double last = 0;
                
                if (char.IsUpper(firstLetter))
                {
                    first += getFirstLetterUpper(firstLetter, number);
                }
                else if (char.IsLower(firstLetter))
                {
                    first += getFirstLetterLower(firstLetter, number);
                }

                if (char.IsUpper(lastLetter))
                {
                    last+= getLastLetterUpper(lastLetter, first);
                }
                else if (char.IsLower(lastLetter))
                {
                    last += getLastLetterLower(lastLetter, first);
                }

                totalsum += last;
            }

            Console.WriteLine("{0:f2}",totalsum);
            
        }

        private static double getLastLetterLower(char lastLetter, double number)
        {
            int fLetter = (int)lastLetter - 96;
            double result = number + fLetter;
            return result;
        }

        private static double getLastLetterUpper(char lastLetter, double number)
        {
            int fLetter = (int)lastLetter - 64;
            double result = number - fLetter;
            return result;
        }

        private static double getFirstLetterLower(char firstLetter, int number)
        {
            int fLetter = (int) firstLetter - 96;
            double result = (double) number * fLetter;
            return result;
        }
         
        private static double getFirstLetterUpper(char firstLetter, int number)
        {
            int fLetter = (int) firstLetter - 64;
            double result = (double) number / fLetter;
            return result;
        }
    }
}