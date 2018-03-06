using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            double area = CalcArea(figure);
            Console.WriteLine("{0:f2}", area);
        }

        private static double CalcArea(string figure)
        {
            double area = 0;
            switch(figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = side * height / 2;
                    break;

                case "square":
                    side = double.Parse(Console.ReadLine());
                    area = side * side;
                    break;

                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                     area = width * height;
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI*radius*radius;
                    break;
            }
            return area;
        }
    }
}