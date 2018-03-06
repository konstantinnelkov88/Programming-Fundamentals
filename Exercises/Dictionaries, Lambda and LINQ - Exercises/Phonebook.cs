using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            List<string> printNames = new List<string>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END") break;
                else
                {
                    var entry = command.Split();
                    string action = entry[0];
                    string name = entry[1];
                    if (action == "A")
                    {
                        string phoneNumber = entry[2];
                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = phoneNumber;
                        }
                        else
                        {
                            phonebook.Add(name, phoneNumber);
                        }
                    }
                    else if (action == "S")
                    {
                        if (phonebook.ContainsKey(name)) Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                        else Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
            }
        }
    }
}