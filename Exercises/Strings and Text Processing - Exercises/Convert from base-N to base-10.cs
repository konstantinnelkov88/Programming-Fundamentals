using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            var baseNumber = input[0];
            var numberToConvert = input[1];

            List<BigInteger> remainder = new List<BigInteger>();
            BigInteger rem = 0;
            int exponent = 0;

            while (numberToConvert > 0)
            {
                BigInteger currentNumber = numberToConvert % 10;
                BigInteger curr = currentNumber * BigInteger.Pow(baseNumber, exponent);
                exponent++;
                remainder.Add(curr);
                numberToConvert = numberToConvert / 10;
            }

            BigInteger sum = 0;

            foreach (var number in remainder)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}