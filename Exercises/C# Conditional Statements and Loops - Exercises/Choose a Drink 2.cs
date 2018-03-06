using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseaDrink
{
    class ChooseaDrink
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            double sum = 0;

            var drink = "";

            switch (proffesion)
            {
                case "Athlete": drink = "Water"; break;
                case "Businessman": drink = "Coffee"; break;
                case "Businesswoman": drink = "Coffee"; break;
                case "SoftUni Student": drink = "Beer"; break;
                default: drink = "Tea"; break;
            }

            switch (drink)
            {
                case "Coffee": sum = quantity * 1.00; break;
                case "Water": sum = quantity * 0.70; break;
                case "Beer": sum = quantity * 1.70; break;
                case "Tea": sum = quantity * 1.20; break;

            }
            Console.WriteLine("The {0} has to pay {1:f2}.", proffesion, sum);
        }
    }
}