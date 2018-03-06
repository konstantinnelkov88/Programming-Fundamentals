using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)

        {
            var dictionary = new Dictionary<string, int>();

            while(true)
            {
                var entry = Console.ReadLine();
                if (entry == "stop") break;
                var resource = int.Parse(Console.ReadLine());

                if(dictionary.ContainsKey(entry))
                {
                    dictionary[entry] +=  resource;
                }
                else
                {
                    dictionary[entry] = resource;
                }
     
            }

            foreach(var resource in dictionary)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}