using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            printSpecialNumbers(n);
        }

        private static void printSpecialNumbers(int n)
        {
            bool isSymetric = false;
            bool isSumOfDigits = false;
            bool isEvenDigit = false;
            for (int i = 1; i <= n; i++)
            {
                isSymetric = checkSymmetric(i);
                isSumOfDigits = checkSumOfDigits(i);
                isEvenDigit = checkEvenDigit(i);
                if (isSymetric && isSumOfDigits && isEvenDigit) Console.WriteLine(i);
            }
        }

        private static bool checkEvenDigit(int number)
        {
            bool evenDigit = false;
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                if (digit % 2 == 0) evenDigit = true;
                number /= 10;
            }
            if (evenDigit) return true;
            else return false;
        }

        private static bool checkSumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 == 0) return true;
            else return false;
        }

        private static bool checkSymmetric(int number)
        {
            int oldNumber = number;
            int SymmtericNumber = 0;
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                SymmtericNumber = SymmtericNumber * 10 + digit;
                number /= 10;
            }
            if (SymmtericNumber == oldNumber) return true;
            return false;
        }
    }
}