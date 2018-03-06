using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfMoney = double.Parse(Console.ReadLine());
            var countOfStudents = int.Parse(Console.ReadLine());
            var priceLightSabersPerSingleSabre = double.Parse(Console.ReadLine());
            var priceOfRobeForSingleRobe = double.Parse(Console.ReadLine());
            var priceOfBeltForSingleBelt = double.Parse(Console.ReadLine());

            double countofStudentsforSabers = Math.Ceiling(1.1 * (double)countOfStudents);
            double countOfstudentsForBelt = countOfStudents - countOfStudents / 6;

            double neededMoney = priceLightSabersPerSingleSabre * countofStudentsforSabers
                                 + priceOfRobeForSingleRobe * countOfStudents
                                 + priceOfBeltForSingleBelt * countOfstudentsForBelt;

            if (neededMoney > amountOfMoney)

                Console.WriteLine("Ivan Cho will need {0:f2}lv more.", neededMoney - amountOfMoney);
            else
                Console.WriteLine("The money is enough - it would cost {0:f2}lv.", neededMoney);
        }
    }
}