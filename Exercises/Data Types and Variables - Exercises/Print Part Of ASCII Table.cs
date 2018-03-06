using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.Write("{0} ", (char)(i));
            }
        }
    }
}