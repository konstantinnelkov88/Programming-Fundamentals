using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void printname(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            printname(n);
        }
    }
}