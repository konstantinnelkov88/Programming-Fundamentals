using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DragonArmy
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var dragons = new Dictionary<string, SortedDictionary<string, double[]>>();
        var regex = new Regex(@"([a-zA-Z]*)\s*([a-zA-Z]*)\s*(null|\d+)\s*(null|\d+)\s*(null|\d+)");

        for (int i = 0; i < n; i++)
        {
            var entry = Console.ReadLine();

            var match = regex.Match(entry);

            if (match.Success)
            {
                var input = entry.Split(' ').ToArray();
                var type = input[0];
                var dragon = input[1];

                var damage = 0;
                var health = 0;
                var armor = 0;
                damage = match.Groups[3].Value == "null" ? 45 : int.Parse(match.Groups[3].Value);
                health = match.Groups[4].Value == "null" ? 250 : int.Parse(match.Groups[4].Value);
                armor = match.Groups[5].Value == "null" ? 10 : int.Parse(match.Groups[5].Value);

         
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, double[]>());
                }

                if (!dragons[type].ContainsKey(dragon))
                {
                    dragons[type][dragon] = new double[3];
                }

                dragons[type][dragon][0] = damage;
                dragons[type][dragon][1] = health;
                dragons[type][dragon][2] = armor;
            }
        }

        foreach (var outerPair in dragons)
        {
            Console.WriteLine("{0}::({1:F}/{2:f}/{3:f})", outerPair.Key, outerPair.Value.Select(x => x.Value[0]).Average(),
                outerPair.Value.Select(x => x.Value[1]).Average(), outerPair.Value.Select(x => x.Value[2]).Average());

            foreach (var inner in outerPair.Value)
            {
                Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", inner.Key, inner.Value[0],
                    inner.Value[1], inner.Value[2]);
            }
        }
    }
}