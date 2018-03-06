using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());
            string[] websites = new string[n];
            decimal totalLoss = 0M;
            BigInteger SecurityToken = BigInteger.Pow(securityKey, n);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var siteVisits = long.Parse(input[1]);
                var siteCommercialPricePerVisit = decimal.Parse(input[2]);
                websites[i] = name;
                totalLoss += siteVisits * siteCommercialPricePerVisit;
            }

            for (int i = 0; i < websites.Length; i++)
            {
                Console.WriteLine(websites[i]);
            }

            Console.WriteLine("Total Loss: {0:F20}", totalLoss);
            Console.WriteLine("Security Token: {0}", SecurityToken);
        }
    }
}