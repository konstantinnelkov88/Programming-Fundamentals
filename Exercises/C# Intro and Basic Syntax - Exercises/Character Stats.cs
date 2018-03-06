using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            //Input
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            //Output
            Console.WriteLine("Name: {0}\nHealth: |{1}{2}|\nEnergy: |{3}{4}|", name,
                new string('|', currentHealth), new string('.', maximumHealth - currentHealth),
                new string('|', currentEnergy), new string('.', maximumEnergy - currentEnergy));
        }
    }
}
