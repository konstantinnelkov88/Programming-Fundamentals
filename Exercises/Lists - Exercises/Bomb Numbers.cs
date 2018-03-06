using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var token = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var bombNumber = token[0];
            var bombPower = token[1];

            int index = numbers.IndexOf(bombNumber);
            while (true)
            {
                if (index != -1)
                {
                    numbers = killlNumbers(index, bombPower, numbers);
                    index = numbers.IndexOf(bombNumber);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(numbers.Sum());
        }

        private static List<int> killlNumbers(int index, int bombPower, List<int> numbers)
        {
            int firstBoundary = index + bombPower;
            int secondBoundary = index - bombPower;

            if (firstBoundary > numbers.Count - 1)
            {
                firstBoundary = numbers.Count - 1;
            }
            if (secondBoundary < 0)
            {
                secondBoundary = 0;
            }
            numbers.RemoveRange(secondBoundary, firstBoundary - secondBoundary + 1);
            return numbers;
        }
    }
}