using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoKilometers
{
    class MilestoKilometers
    {
        static void Main(string[] args)

        {
           var miles = double.Parse(Console.ReadLine());
           Console.WriteLine("{0:f2}", miles * 1.60934);
        }
    }
}
