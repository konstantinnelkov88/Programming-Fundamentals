using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", 
                                   "Best product of its category.", "Exceptional product.", 
                                   "I can’t live without this product." };
            string[] Events = { "Now I feel good.", "I have succeeded with this product.", 
                                  "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", 
                                  "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] Cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            for (int i = 0; i < n; i++)
            {

                Random random = new Random();

                int phrasesIndex = random.Next(0, 5);
                int EventsIndex = random.Next(0, 6);
                int AuthosIndex = random.Next(0, 8);
                int CitiesIndex = random.Next(0, 5);

                Console.WriteLine("{0}{1}{2}-{3}", Phrases[phrasesIndex], Events[EventsIndex], Authors[AuthosIndex],
                                                                                                Cities[CitiesIndex]);
            }
        }
    }
}