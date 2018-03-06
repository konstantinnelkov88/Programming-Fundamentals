using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestStart = numbers[0];
            int bestLength = 1;
            int start = numbers[0];
            int length = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i-1])
                {
                    length++;
                }
                else
                {
                    start = numbers[i];
                    length = 1;
                }

                if(length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", bestStart);
            }
            Console.WriteLine();
        }
    }
}