using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            var s = double.Parse(Console.ReadLine());
            var param = Console.ReadLine();
            PrintParam(s, param);
        }

        private static void PrintParam(double s, string param)
        {
            double result = 0;
            switch (param)
            {
                case "face":
                    result = Math.Sqrt(2 * s * s);
                    break;

                case "space":
                    result = Math.Sqrt(3 * s * s);
                    break;

                case "volume":
                    result = s * s * s;
                    break;

                case "area":
                    result = s * s * 6;
                    break;
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}