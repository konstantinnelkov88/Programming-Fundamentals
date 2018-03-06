using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBase
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

            while (numberToConvert > 0)
            {
                rem = numberToConvert % baseNumber;
                remainder.Add(rem);
                numberToConvert = numberToConvert / baseNumber;
            }
            remainder.Reverse();
            Console.WriteLine(string.Join("", remainder));
        }
    }
}