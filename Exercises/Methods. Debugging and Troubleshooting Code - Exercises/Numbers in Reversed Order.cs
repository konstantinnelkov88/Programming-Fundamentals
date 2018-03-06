using System;
using System.Linq;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var entry = Console.ReadLine();
            printReverse(entry);
        }
        private static void printReverse(string entry)
        {
            string reversedStr = new string(entry.Reverse().ToArray());
            Console.WriteLine(reversedStr);
        }

    }
}