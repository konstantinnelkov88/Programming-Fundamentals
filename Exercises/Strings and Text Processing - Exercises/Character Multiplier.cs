using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var firstWord = input[0];
            var secondWord = input[1];

            var flen = firstWord.Length;
            var slen = secondWord.Length;

            int totalSum = 0;

            int smaller = flen > slen ? slen : flen;

            for (int i = 0; i < smaller; i++)
            {
                totalSum += (int)firstWord[i] * (int)secondWord[i];
            }

            if (flen > slen)
            {
                for (int i = slen; i < flen; i++)
                {
                    totalSum += (int)firstWord[i];
                }
            }
            else
            {
                for (int i = flen; i < slen; i++)
                {
                    totalSum += secondWord[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}