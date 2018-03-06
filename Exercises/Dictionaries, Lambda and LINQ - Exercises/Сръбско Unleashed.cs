using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SrabskoUnleashed
{
    static void Main(string[] args)
    {
        var singers = new Dictionary<string, Dictionary<string, long>>();

        for (int i = 0; i < 50; i++)
        {
            var entry = Console.ReadLine();
            if (entry == "End") break;

            string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

            if (Regex.IsMatch(entry, correctInputPattern))
            {
                Match match = Regex.Match(entry, correctInputPattern);

                string singer = match.Groups[1].Value.Trim();
                string venue = match.Groups[3].Value.Trim();
                int ticketsPrice = int.Parse(match.Groups[5].Value);
                int ticketsCount = int.Parse(match.Groups[6].Value);
                int totalMoney = ticketsCount * ticketsPrice;

                if (!singers.ContainsKey(venue))
                {
                    singers[venue] = new Dictionary<string, long>();
                    singers[venue].Add(singer, totalMoney);
                }
                else
                {
                    if (!singers[venue].ContainsKey(singer)) singers[venue].Add(singer, totalMoney);
                    else singers[venue][singer] += totalMoney;
                }
            } 
        }
        foreach (var venues in singers)
        {
            Console.WriteLine("{0}", venues.Key);
            var currentSingers = venues.Value;

            foreach (var currentSinger in currentSingers.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("#  {0} -> {1}", currentSinger.Key, currentSinger.Value);
            }
        }
    }
}