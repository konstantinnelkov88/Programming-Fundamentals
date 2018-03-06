using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            foreach (var number in numbers)
            {
                int currentNumber = number;
                int result = 0;
                while (currentNumber > 0)
                {
                    result = result * 10 + currentNumber % 10;
                    currentNumber /= 10;
                }
                sum += result;
            }
			
            Console.WriteLine(sum);
        }
    }
}