using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDaysCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = Console.ReadLine();
            var endDate = Console.ReadLine();

            DateTime firstDate = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11];
            int WorkingDaysCounter = 0;

            holidays[0] = new DateTime(4, 1, 1);
            holidays[1] = new DateTime(4, 3, 3);
            holidays[2] = new DateTime(4, 5, 1);
            holidays[3] = new DateTime(4, 5, 6);
            holidays[4] = new DateTime(4, 5, 24);
            holidays[5] = new DateTime(4, 9, 6);
            holidays[6] = new DateTime(4, 9, 22);
            holidays[7] = new DateTime(4, 11, 1);
            holidays[8] = new DateTime(4, 12, 24);
            holidays[9] = new DateTime(4, 12, 25);
            holidays[10] = new DateTime(4, 12, 26);


            for (DateTime loop = firstDate; loop <= secondDate; loop = loop.AddDays(1))
            {

                DayOfWeek day = loop.DayOfWeek;

                DateTime temp = new DateTime(4, loop.Month, loop.Day);


                if (!holidays.Contains(temp) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
                {
                    WorkingDaysCounter++;
                }
            }
            Console.WriteLine(WorkingDaysCounter);
        }
    }
}