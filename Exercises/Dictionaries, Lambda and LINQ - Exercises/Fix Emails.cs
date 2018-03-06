using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>();

            while(true)
            {
                var name = Console.ReadLine();

                if (name == "stop") break;

                var email = Console.ReadLine();

                string lastWords = email[email.Length - 2].ToString() + email[email.Length-1].ToString();

                if(lastWords != "uk" && lastWords != "us")
                {
                    dictionary.Add(name, email);
                }
            }

            foreach( var entry in dictionary)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }

        }
    }
}