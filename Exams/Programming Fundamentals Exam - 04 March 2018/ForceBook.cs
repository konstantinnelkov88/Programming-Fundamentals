using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ForceBook
{
    class ForceUser
    {
        public string Name { get; set; }
        public string Side { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ForceUser> ForceUsers = new List<ForceUser>();
            Dictionary<string, int> Sides = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Lumpawaroo") break;

                var regex = @"(.*\s*.*)\s([\|\->]+)\s(.*\s*.*)";

                var match = Regex.Match(input, regex);
                var Name = string.Empty;
                var Side = string.Empty;
                var command = string.Empty;

                if (match.Success)
                {
                    command = match.Groups[2].Value;
                }

                if (command == "|")
                {
                        Name = match.Groups[3].Value;
                        Side = match.Groups[1].Value;

                    ForceUser ForceUser = new ForceUser();
                    ForceUser.Name = Name;
                    ForceUser.Side = Side;

                    int count = ForceUsers.Where(x => x.Name == Name).ToList().Count;

                    if (count == 0)
                    {
                        ForceUsers.Add(ForceUser);

                        if (Sides.ContainsKey(Side))
                        {
                            Sides[Side]++;
                        }
                        else
                        {
                            Sides.Add(Side,1);
                        }
                    }
                }

                if (command == "->")

                {
                        Name = match.Groups[1].Value;
                        Side = match.Groups[3].Value;
                    
                    ForceUser ForceUser = new ForceUser();
                    ForceUser.Name = Name;
                    ForceUser.Side = Side;

                    int count = ForceUsers.Where(x => x.Name == Name).ToList().Count;

                    if (count > 0)
                    {
                        ForceUser existingUser = ForceUsers.Find(x => x.Name == Name);

                        Sides[existingUser.Side]--;
                        existingUser.Side = Side;
                        
                        if (!Sides.ContainsKey(Side))
                        {
                            Sides[existingUser.Side] = 1;
                        }
                        else
                        {
                            Sides[existingUser.Side]++;
                        }

                        Console.WriteLine("{0} joins the {1} side!", Name, Side);
                    }
                    else if (count == 0)
                    {
                        ForceUsers.Add(ForceUser);

                        if (Sides.ContainsKey(Side))
                        {
                            Sides[Side]++;
                        }
                        else
                        {
                            Sides.Add(Side, 1);
                        }

                        Console.WriteLine("{0} joins the {1} side!", Name, Side);
                    }
                }
            }

            ForceUsers = ForceUsers.Distinct().ToList();

            foreach (var side in Sides.Where(x=>x.Value > 0).OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {

                Console.WriteLine("Side: {0}, Members: {1}",side.Key, side.Value);

                foreach (ForceUser forceUser in ForceUsers.Where(x=>x.Side == side.Key).ToList().OrderBy(x=>x.Name))
                {
                    Console.WriteLine("! {0}",forceUser.Name);
                }
            }
        }
    }
}