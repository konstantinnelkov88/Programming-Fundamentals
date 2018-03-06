using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            int countL = 0;
            int countR = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i]) countL++;
                else break;
            }

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[arr1.Length-1-i] == arr2[arr2.Length-1-i]) countR++;
                else break;
            }
            Console.WriteLine("{0}", Math.Max(countL, countR));
        }
    }
}