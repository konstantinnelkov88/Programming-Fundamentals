using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string hex = Convert.ToString(dec, 16);
            Console.WriteLine(hex.ToUpper());
            string binary = Convert.ToString(dec, 2);
            Console.WriteLine(binary);
        }
    }
}