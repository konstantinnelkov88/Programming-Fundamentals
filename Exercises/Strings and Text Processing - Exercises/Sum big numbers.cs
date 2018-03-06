using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine().TrimStart(new char[] { '0' }); ;
            string s2 = Console.ReadLine().TrimStart(new char[] { '0' }); ;

            char[] ResultOfSum = null;

            if (s1.Length >= s2.Length)
            {
                ResultOfSum = Sum(s1, s2);
            }
            else
            {
                ResultOfSum = Sum(s2, s1);
            }

            Console.WriteLine(ResultOfSum);
        }

        private static char[] Sum(string s1, string s2)
        {
            int flen = s1.Length;
            int slen = s2.Length;

            char[] rev1 = s1.ToCharArray();
            Array.Reverse(rev1);
            char[] rev2 = s2.ToCharArray();
            Array.Reverse(rev2);

            string result = string.Empty;

            int numberInMind = 0;

            for (int i = 0; i < flen; i++)
            {
                int temp = 0;

                if (i < slen)
                {
                    temp = (int)Char.GetNumericValue(rev1[i]) + (int)Char.GetNumericValue(rev2[i]) + numberInMind;
                }
                else
                {
                    temp = (int)Char.GetNumericValue(rev1[i]) + numberInMind;
                }

                if (temp < 10)
                {
                    result += temp.ToString();
                    numberInMind = 0;
                }

                else
                {
                    result += (temp % 10).ToString();
                    numberInMind = 1;
                }
            }
            if (numberInMind == 1)
            {
                result += "1";
            }

            char[] array = result.ToCharArray();

            Array.Reverse(array);

            return array;
        }
    }
}