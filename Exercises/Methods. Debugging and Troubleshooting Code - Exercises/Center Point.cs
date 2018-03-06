using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)

        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var point = closestPoint(x1, y1, x2, y2);
           Console.WriteLine("({0}, {1})", point.ElementAt(0), point.ElementAt(1));
        }

        private static List<double> closestPoint(double x1, double y1, double x2, double y2)
        {
            var point = new List<double>();
            var distanceToCenter1 = Math.Sqrt(x1 * x1 + y1 * y1);
            var distanceToCenter2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distanceToCenter2 > distanceToCenter1)
            {
                point.Add(x1);
                point.Add(y1);
            }
            else
            {
                point.Add(x2);
                point.Add(y2);
            }
            return point;
        }
    }
}