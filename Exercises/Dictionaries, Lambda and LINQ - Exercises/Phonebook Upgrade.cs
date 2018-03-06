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
            var phonebook = new SortedDictionary<string, string>();
            
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END") break;
                else
                {
                    if (command == "ListAll")
                    {
                       foreach(var entry in phonebook)
                       {
                           Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
                       }
                    }

                    else
                    {
                        var entry = command.Split(' ');
                        var action = entry[0];
                        var name = entry[1];
                        
                        if (action == "A")
                        {
                            var phoneNumber = entry[2];
                            if (phonebook.ContainsKey(name))
                            {
                                phonebook[name] = phoneNumber;
                            }
                            else
                            {
                                phonebook.Add(name, phoneNumber);
                            }
                        }

                        else if(action == "S")
                        {
                            if (phonebook.ContainsKey(name))
                            {
                                Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                            }
                            else
                            {
                                Console.WriteLine("Contact {0} does not exist.", name);
                            }
                        }
                    }
                }
            }
        }
    }
}