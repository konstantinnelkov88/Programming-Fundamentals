using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string discount = Console.ReadLine();
            double price = 0;
            double pricePerPerson = 0;
            var hall = "";

            if (groupSize <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 75)
            {
                if(groupSize - 50 < 12)
                {
                    price = 2500;
                    hall = "Small Hall";
                }
                else
                {
                    price = 5000;
                    hall = "Terrace";
                }
            }

            else if (groupSize > 75 && groupSize <= 120)
            {
                if (groupSize - 75 < 22)
                {
                    price = 5000;
                    hall = "Terrace";
                }
                else
                {
                    price = 7500;
                    hall = "Great Hall";
                }
            }
            else price = 0;

            switch (discount)
            {
                case "Normal": pricePerPerson = (500 + price) * 0.95/ groupSize; break;
                case "Gold": pricePerPerson = (750 + price) * 0.90 / groupSize; break;
                case "Platinum": pricePerPerson = (1000 + price) * 0.85 / groupSize; break;
            }

            if (price == 0) Console.WriteLine("We do not have an appropriate hall.");
            else
            {
                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
            }
        }
    }
}