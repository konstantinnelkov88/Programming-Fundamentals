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
            string s1 = Console.ReadLine().TrimStart(new char[] { '0' });

            int n = int.Parse(Console.ReadLine());

            int flen = s1.Length;

            char[] rev1 = s1.ToCharArray();
            Array.Reverse(rev1);

            string result = string.Empty;

            int numberInMind = 0;

            for (int i = 0; i < flen; i++)
            {
                int temp = (int)Char.GetNumericValue(rev1[i]) * n + numberInMind;

                if (temp < 10)
                {
                    result += temp.ToString();
                    numberInMind = 0;
                }

                else
                {
                    result += (temp % 10).ToString();
                    numberInMind = temp / 10;
                }
            }
            if (numberInMind > 0)
            {
                result += numberInMind;
            }


            if (result[result.Length-1] == '0')
            {
                result = "0";
            }
           
            char[] array = result.ToCharArray();
           
            Array.Reverse(array);

            Console.WriteLine(array);
        }

    }
}