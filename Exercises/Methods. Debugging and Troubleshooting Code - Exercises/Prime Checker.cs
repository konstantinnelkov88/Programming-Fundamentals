using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            var n = ulong.Parse(Console.ReadLine());
            IsPrime(n);
        }

        private static void IsPrime(ulong n)
        {
            if (n==0 || n==1)
            {
                Console.WriteLine("False");
            }
            else
            {
                bool prime = true;
                for (ulong i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                    }
                }
                if (prime) Console.WriteLine("True");
                else Console.WriteLine("False");
            }
        }
    }
}