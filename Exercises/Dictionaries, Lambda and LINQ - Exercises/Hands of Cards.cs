using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            while (true)
            {
                var entry = Console.ReadLine();

                if (entry == "JOKER") break;

                string[] input = entry.Split(':').ToArray();

                var name = input[0];

                List<string> cards = input[1].Replace(" ", string.Empty).Split(',').ToList();


                if (dictionary.ContainsKey(name)) dictionary[name] = dictionary[name].Union(cards).Distinct().ToList();

                else dictionary[name] = cards.Distinct().ToList();
            }

            foreach (KeyValuePair<string, List<string>> pair in dictionary)
            {

                int sum = 0;

                foreach (var card in pair.Value)
                {
                    int currentSum = 0;

                    if (card.Length == 2)
                    {
                        switch (card[0])
                        {
                            case '2': currentSum += 2; break;
                            case '3': currentSum += 3; break;
                            case '4': currentSum += 4; break;
                            case '5': currentSum += 5; break;
                            case '6': currentSum += 6; break;
                            case '7': currentSum += 7; break;
                            case '8': currentSum += 8; break;
                            case '9': currentSum += 9; break;
                            case 'J': currentSum += 11; break;
                            case 'Q': currentSum += 12; break;
                            case 'K': currentSum += 13; break;
                            case 'A': currentSum += 14; break;
                        }
                        switch (card[1])
                        {
                            case 'S': currentSum *= 4; break;
                            case 'H': currentSum *= 3; break;
                            case 'D': currentSum *= 2; break;
                            case 'C': currentSum *= 1; break;
                        }
                    }
                    else
                    {
                        switch (card[2])
                        {
                            case 'S': currentSum += 40; break;
                            case 'H': currentSum += 30; break;
                            case 'D': currentSum += 20; break;
                            case 'C': currentSum += 10; break;
                        }
                    }
                    sum += currentSum;
                }
                Console.Write("{0}: {1}", pair.Key, sum);
                Console.WriteLine();
            }
        }
    }
}