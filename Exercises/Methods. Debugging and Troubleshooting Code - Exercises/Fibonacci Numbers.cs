using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonaciNumbers
{
    class FibbonaciNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            fib(n);
        }

        private static void fib(int n)
        {
            
            int fnumber = 0;
            int snumber = 1;
            int currentNumber = 1;
            for (int i = 0; i < n; i++)
            {

                currentNumber = fnumber + snumber;
                fnumber = snumber;
                snumber = currentNumber;
            }

            Console.WriteLine(currentNumber);
        }
    }
}