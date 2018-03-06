using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            int[] bestSeq = new int[len];
            var bestSum = 0;
            var bestIndex = 0;
            var bestLength = 0;
            var counter = 0;
            var countLength = 1;
            var bestCount = 0;

            while (true)
            {
                counter++;

                var input = Console.ReadLine();

                if (input == "Clone them!") break;

                var tokens = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int startIndex = Array.FindIndex(tokens, w => w == 1);

                int  firstIndex = startIndex;

                int currentLength = 0;

                for (int i = startIndex + 1; i < tokens.Length; i++)
                {
                    if (tokens[i] == 1 && tokens[i] == tokens[i-1])
                    {
                        countLength++;

                        if (currentLength < countLength)
                        {
                            currentLength = countLength;
                            firstIndex = startIndex;
                        }
                    }

                    else
                    {
                        if (tokens[i] == 1)
                        {
                            startIndex = i;
                            countLength = 1;
                        }
                    }
                }
                countLength = 1;

                var Sum = tokens.Sum();

                if (currentLength == bestLength)
                {
                    if (firstIndex == bestIndex)
                    {
                        if (Sum > bestSum)
                        {
                            bestSum = Sum;
                            bestSeq = tokens;
                            bestCount = counter;
                        }
                    }
                    else if (firstIndex < bestIndex)
                    {
                        bestSum = Sum;
                        bestSeq = tokens;
                        bestIndex = firstIndex;
                        bestCount = counter;
                    }
                }
                else if (currentLength > bestLength)
                {
                    bestSum = Sum;
                    bestSeq = tokens;
                    bestIndex = firstIndex;
                    bestLength = currentLength;
                    bestCount = counter;
                }
            }

            Console.WriteLine("Best DNA sample {0} with sum: {1}.", bestCount, bestSum);
            Console.WriteLine(string.Join(" ", bestSeq));
        }
    }
}