using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var primes = FindPrimesInRange(start, end);
            foreach (int prime in primes)
            {
                if (prime == primes.Last()) Console.Write("{0} ", prime);
                else  Console.Write("{0}, ", prime);
            }
        }

        private static List<int> FindPrimesInRange(int start, int end)
        {
            var primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool isPrime = checkPrime(i);
                if(isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private static bool checkPrime(int n)
        {
            if(n==0 || n==1)
            {
                return false;
            }
            else
            {
                bool prime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                    }
                }
                if (prime) return true;
                else return false;
            }
        }
    }
}