using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceofEqualElements
{
    class MaxSequenceofEqualElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bestStart = numbers[0];
            int bestLength = 1;
            int start = numbers[0];
            int length = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    length++;
                    if (bestLength < length)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start = numbers[i];
                    length = 1;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(bestStart + " ");
            }
        }
    }
}