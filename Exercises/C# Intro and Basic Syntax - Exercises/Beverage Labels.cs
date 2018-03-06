using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            //Input
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            //Output
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, 
                (double)energy / 100 * (double)volume, 
                (double)sugar / 100 * (double)volume);
        }
    }
}