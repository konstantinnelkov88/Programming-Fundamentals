using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class LegendaryFarming
{
    static void Main(string[] args)
    {
        var materials = new SortedDictionary<string, int>();

        materials.Add("fragments", 0);
        materials.Add("shards", 0);
        materials.Add("motes", 0);

        var keyMaterials = new Dictionary<string, int>();

        bool flag = false;

        var winner = string.Empty;
        for (int j = 0; j < 9; j++)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length; i += 2)
            {

                if (!materials.ContainsKey(input[i + 1].ToLower()))
                {
                    materials.Add(input[i + 1].ToLower(), int.Parse(input[i]));
                }
                else
                {
                    materials[input[i + 1].ToLower()] += int.Parse(input[i]);
                }

                if (materials[input[i + 1].ToLower()] >= 250 && (input[i + 1].ToLower() == "fragments" ||
                                                                 input[i + 1].ToLower() == "motes" ||
                                                                 input[i + 1].ToLower() == "shards"))
                {
                    if (input[i + 1].ToLower() == "fragments") winner = "Valanyr";
                    if (input[i + 1].ToLower() == "motes") winner = "Dragonwrath";
                    if (input[i + 1].ToLower() == "shards") winner = "Shadowmourne";

                    materials[input[i + 1].ToLower()] -= 250;
                    flag = true;
                    break;
                }
            }
            if (flag) break;
        }

        keyMaterials["fragments"] = materials["fragments"];
        keyMaterials["motes"] = materials["motes"];
        keyMaterials["shards"] = materials["shards"];

        Console.WriteLine("{0} obtained!", winner);

        foreach (var keyMaterial in keyMaterials.OrderByDescending(x => x.Value))
        {
            Console.WriteLine("{0}: {1}", keyMaterial.Key, keyMaterial.Value);
        }
        foreach (var material in materials)
        {
            if (material.Key == "fragments" || material.Key == "motes" || material.Key == "shards") continue;
            else
            {
                Console.WriteLine("{0}: {1}", material.Key, material.Value);
            }
        }

    }
}