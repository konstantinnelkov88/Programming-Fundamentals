using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            bool[] numbers = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                numbers[i] = true;
            }

            numbers[0] = false;
            numbers[1] = false;

            int minNumber = 2;

            for (int i = 0; i <= n; i++)
            {
                numbers[minNumber] = true;

                for (int j = minNumber+1; j <= n; j++)
                {
                    if (j % minNumber == 0) numbers[j] = false;
                }

                for (int j = minNumber + 1; j <= n; j++)
                {
                    if (numbers[j] == true)
                    {
                        minNumber = j;
                        break;
                    }
                }
            }
            for (int i = 0; i <= n; i++)
            {
                if (numbers[i] == true) Console.WriteLine("{0} ", i);
            }
        }
    }
}