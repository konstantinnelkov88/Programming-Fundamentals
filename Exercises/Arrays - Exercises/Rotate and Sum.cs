using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];

            for (int i = 1; i <= r; i++)
            {
                int help = arr[arr.Length-1];
                for (int j = arr.Length -1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = help;

                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] = sum[j] + arr[j];
                }
            }
            foreach (int n in sum)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
        }
    }
}