using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserLogs
{
    static void Main(string[] args)
    {
        var users = new SortedDictionary<string, Dictionary<string, int>>();

        while (true)
        {
            var entry = Console.ReadLine();

            if (entry == "end") break;

            var input = entry.Split(' ');

            var user = input[2].Remove(0, 5);

            var IP = input[0].Remove(0, 3);

            if (!users.ContainsKey(user))
            {

                users[user] = new Dictionary<string, int>();
                users[user].Add(IP, 1);
            }

            else
            {
                if (!users[user].ContainsKey(IP))
                {
                    users[user].Add(IP, 1);
                }
                else users[user][IP]++;
            }
        }

        foreach (var user in users)
        {
            var users_name = user.Key;
            var users_IP = user.Value;

            Console.WriteLine("{0}: ", user.Key);

            foreach (var userIP in users_IP)
            {
                var IP = userIP.Key;
                var count = userIP.Value;

                if (userIP.Key == users_IP.Last().Key) Console.Write("{0} => {1}. ", IP, count);
                else Console.Write("{0} => {1}, ", IP, count);
            }
            Console.WriteLine();
        }
    }
}