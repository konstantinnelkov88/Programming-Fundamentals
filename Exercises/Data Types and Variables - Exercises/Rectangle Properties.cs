using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)

        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine((a+b)*2);
            Console.WriteLine(a*b);
            Console.WriteLine(Math.Sqrt(a*a + b*b));
        }
    }
}