using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string fWord = input[0];
            string sWord = input[1];

            bool ex = true;

            if (fWord.Length >= sWord.Length)
            {
                 ex = exchange(fWord, sWord);
            }
            else
            {
                 ex = exchange(sWord, fWord);
            }

            Console.WriteLine(ex.ToString().ToLower());
        }

        static bool exchange(string fWord, string sWord)
        {
            Dictionary<char, char> Map = new Dictionary<char, char>();

            int flen = fWord.Length;
            int slen = sWord.Length;

            bool exchangeable = true;

            for (int i = 0; i < slen; i++)
            {
                if (!Map.ContainsKey(fWord[i]))
                {
                    Map[fWord[i]] = sWord[i];
                }

                else if(Map[fWord[i]] != sWord[i])
                {
                    exchangeable = false;
                }
            }

           
                for (int i = slen ; i < flen; i++)
                {
                    if (!Map.ContainsKey(fWord[i]))
                    {
                        exchangeable = false;
                    }
                }
            return exchangeable;
        }
    }
}