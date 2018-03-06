using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialTrail
{
    class FactorialTrail
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            
            int count = checkTrailsOfZeroes(factorial);
            Console.WriteLine(count);
        }

        private static int checkTrailsOfZeroes(BigInteger fact)
        {
                string str = fact.ToString();
                string[] ss = str.Split('0');
                int count = 0;
                for (int i = ss.Length - 1; i >= 0; i--)
                {
                    if (ss[i] == "")
                        count = count + 1;
                    else
                        break;
                }
            return count;
        }
    }
}