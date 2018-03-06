using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class CityWeather
    {
        public float temp { get; set; }
        public string weather { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, CityWeather>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end") break;

                var regex = @"([A-Z][A-Z])([0-9]*\.[0-9]*)([A-Za-z]+)\|";

                MatchCollection forecasts = Regex.Matches(input, regex);

                foreach (Match forecast in forecasts)
                {
                    var town = forecast.Groups[1].ToString();

                    CityWeather city = new CityWeather();

                    city.temp = float.Parse(forecast.Groups[2].Value);
                    city.weather = forecast.Groups[3].Value;
  
                    if (!dict.ContainsKey(town))
                    {
                        dict.Add(town,city);
                    }
                    else
                    {
                        dict[town] = city;
                    }
                }
            }

            var ordered = dict.OrderBy(x => x.Value.temp);

            foreach (var towns in ordered)
            {
                Console.WriteLine("{0} => {1:f2} => {2}",towns.Key,towns.Value.temp,towns.Value.weather);
            }
        }
    }
}