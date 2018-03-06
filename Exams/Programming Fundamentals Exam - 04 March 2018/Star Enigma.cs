using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarEnigma
{
    class Planet
    {
        public string planetName { get; set; }
        public long population { get; set; }
        public char attackType { get; set; }
        public long soldierCount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Planet> planets = new List<Planet>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                var input = Console.ReadLine();

                int count = input.Count(x => x == 's' || x == 't' || x == 'a' || x == 'r'
                                          || x == 'S' || x == 'T' || x == 'A' || x == 'R');

                string result = string.Empty;

                foreach (char c in input)
                {
                    int newChar = (int) c - count;
                    char theNewChar = (char) newChar;
                    result += theNewChar;
                }

                var regex = @"@([A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([A|D]{0,1})![^@\-!:>]*->([\d]+)";

                var match = Regex.Match(result, regex);
                string planetName = string.Empty;
                long population = 0;
                char attackType = Char.MinValue;
                long soldierCount = 0;

                if (match.Success)
                {
                     planetName = match.Groups[1].Value;
                     population = long.Parse(match.Groups[2].Value);
                     attackType = char.Parse(match.Groups[3].Value);
                     soldierCount = long.Parse(match.Groups[4].Value);
                }

                var planet = new Planet();
                planet.planetName = planetName;
                planet.attackType = attackType;
                planet.soldierCount = soldierCount;
                planet.population = population;


                planets.Add(planet);
            }

            Console.WriteLine("Attacked planets: {0}",planets.Where(x=>x.attackType == 'A').ToList().Count());
            foreach (Planet planet in planets.OrderBy(x=>x.planetName))
            {
                if (planet.attackType == 'A')
                {
                    Console.WriteLine("-> {0}",planet.planetName);
                }
            }

            Console.WriteLine("Destroyed planets: {0}", planets.Where(x => x.attackType == 'D').ToList().Count());
            foreach (Planet planet in planets.OrderBy(x => x.planetName))
            {
                if (planet.attackType == 'D')
                {
                    Console.WriteLine("-> {0}", planet.planetName);
                }
            }
        }
    }
}