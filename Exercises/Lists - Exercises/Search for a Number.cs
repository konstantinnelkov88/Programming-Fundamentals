using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchforaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var token = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int takeElements = token[0];
            int deleteElements = token[1];
            int searchedNumer = token[2];
            bool found = false;


           listNumbers.Take(takeElements);
           listNumbers.RemoveRange(0,deleteElements);

            foreach (var number in listNumbers)
            {
                if (number == searchedNumer)
                {
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}