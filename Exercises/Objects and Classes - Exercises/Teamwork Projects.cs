using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProject
{
    class Team
    {
        public string TeamName { get; set; }

        public List<string> MemberList { get; set; }

        public string CreatorName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Team> TeamList = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray();

                var creatorname = input[0];
                var teamname = input[1];

                if (TeamList.Any(c => c.TeamName == teamname))
                {
                    Console.WriteLine("Team {0} was already created!", teamname);
                }
                else
                {
                    if (TeamList.Any(x => x.CreatorName == creatorname))
                    {
                        Console.WriteLine("{0} cannot create another team!", creatorname);
                    }
                    else
                    {
                        Team newTeam = new Team();
                        newTeam.CreatorName = creatorname;
                        newTeam.TeamName = teamname;
                        newTeam.MemberList = new List<string>();
                        TeamList.Add(newTeam);

                        Console.WriteLine("Team {0} has been created by {1}!", teamname, creatorname);
                    }
                }
            }


            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                var Join = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var MemberToJoin = Join[0];
                string TeamToJoin = Join[1];

                if (TeamList.Any(x => x.TeamName == TeamToJoin))
                {
                    if (TeamList.Any(c => c.MemberList.Contains(MemberToJoin)) || TeamList.Any(v => v.CreatorName == MemberToJoin))
                    {
                        Console.WriteLine("Member {0} cannot join team {1}!", MemberToJoin, TeamToJoin);
                    }
                    else
                    {
                        Team existingTeam = TeamList.First(x => x.TeamName == TeamToJoin);
                        existingTeam.MemberList.Add(MemberToJoin);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} does not exist!", TeamToJoin);
                }
            }

            var ordered = TeamList.OrderByDescending(x => x.MemberList.Count).ThenBy(b => b.TeamName);

            var teamsToDisband = TeamList.OrderBy(x => x.TeamName);
            foreach (var team in ordered)
            {
                if (team.MemberList.Count != 0)
                {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine("- {0}", team.CreatorName);
                    foreach (var member in team.MemberList.OrderBy(s => s))
                    {
                        Console.WriteLine("-- {0}", member);
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                if (team.MemberList.Count == 0)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }
}