using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAgreggator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            var users = new SortedDictionary<string, SortedDictionary<string, int>>();
            var totalDuration = new SortedDictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                var IP = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);
                
                if (!users.ContainsKey(user))
                {
                    users[user] = new SortedDictionary<string, int>();
                    users[user].Add(IP, duration);
                }

                else
                {
                    if (!users[user].ContainsKey(IP))
                    {
                        users[user].Add(IP, duration);
                    }
                    else
                    {
                        users[user][IP] += duration;
                    }
                }
            }

            foreach (var user in users)
            {
                int totalDur = 0;
                var userName = user.Key;
                var durations = user.Value;

                foreach (var IPs in durations)
                {
                    totalDur += IPs.Value;
                }

                totalDuration.Add(userName, totalDur);
            }

            foreach (var user in totalDuration)
            {
                Console.Write("{0}: {1} ", user.Key, user.Value);
                Console.Write("[");
                foreach (var IPs in users[user.Key])
                {
                    if (IPs.Key == users[user.Key].Last().Key)
                    {
                        Console.Write("{0}", IPs.Key);
                    }
                    else
                    {
                        Console.Write("{0}, ", IPs.Key);
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}