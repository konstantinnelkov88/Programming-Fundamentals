using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)

        {
            var population = new Dictionary<string, Dictionary<string, long>>();
            var test = new Dictionary<string, long>();

            while (true)
            {
                var entry = Console.ReadLine();

                if (entry == "report") break;

                var input = entry.Split('|');

                var Country = input[1];
                var pops = long.Parse(input[2]);
                var City = input[0];

                if (!population.ContainsKey(Country))
                {
                    population[Country] = new Dictionary<string, long>();
                    population[Country].Add(City,pops);
                }
                else
                {
                    population[Country].Add(City,pops);
                }
            }
           
            foreach (var country in population)
            {
                long population_country = 0;
                var currentCountry = country.Key;
                var cities = country.Value;

                foreach (var city in cities)
                {
                    var currentPopulation = city.Value;
                    population_country += currentPopulation;
                }

                test.Add(currentCountry,population_country);
            }
            var sortedcountries = test.OrderByDescending(x => x.Value);

            foreach (var country in sortedcountries)
            {
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value);

                foreach (var city in population[country.Key].OrderByDescending(x => x.Value))
                {
                   Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}