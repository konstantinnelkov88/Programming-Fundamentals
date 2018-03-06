using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var fisrtLine = closestPoint(x1, y1, x2, y2);
            var secondLine = closestPoint(x3, y3, x4, y4);
            var pointsOfLongerLine = FindLongerLine(fisrtLine, secondLine);

            Console.WriteLine("({0}, {1})({2}, {3})", pointsOfLongerLine.ElementAt(0),
                                                    pointsOfLongerLine.ElementAt(1),
                                                    pointsOfLongerLine.ElementAt(2),
                                                    pointsOfLongerLine.ElementAt(3));
        }

        private static List<double> FindLongerLine(List<double> fisrtLine, List<double> secondLine)
        {

            var xLine1 = fisrtLine.ElementAt(2) - fisrtLine.ElementAt(0);
            var yLine1 = fisrtLine.ElementAt(3) - fisrtLine.ElementAt(1);
            var xLine2 = secondLine.ElementAt(2) - secondLine.ElementAt(0);
            var yLine2 = secondLine.ElementAt(3) - secondLine.ElementAt(1);

            if (Math.Sqrt(xLine1 * xLine1 + yLine1 * yLine1) >= Math.Sqrt(xLine2 * xLine2 + yLine2 * yLine2)) return fisrtLine;
            else return secondLine;
        }

        private static List<double> closestPoint(double x1, double y1, double x2, double y2)
        {
            var point = new List<double>();
            var distanceToCenter1 = Math.Sqrt(x1 * x1 + y1 * y1);
            var distanceToCenter2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distanceToCenter2 >= distanceToCenter1)
            {
                point.Add(x1);
                point.Add(y1);
                point.Add(x2);
                point.Add(y2);
            }
            else
            {
                point.Add(x2);
                point.Add(y2);
                point.Add(x1);
                point.Add(y1);
            }
            return point;
        }
    }
}