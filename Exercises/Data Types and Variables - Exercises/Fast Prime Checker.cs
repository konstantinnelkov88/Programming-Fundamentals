using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
                {
                     bool isPrime = true;
                  for (int div = 2; div <= Math.Sqrt(i); div++)
                     {
                         if (i % div == 0)
                             {
                                 isPrime = false;
                                    break;
                                }
                      }
                    Console.WriteLine("{0} -> {1}",i, isPrime );
                }               
        }
    }
}