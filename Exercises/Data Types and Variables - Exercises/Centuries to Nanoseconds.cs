using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)

        {
              var centuries = sbyte.Parse(Console.ReadLine());
              var years = (ushort)(centuries) * (ushort)(100);
              var HarshDays = 0;

              if (years >= 100 && years < 500) 
              {
                  HarshDays = years / 4 - years/100;
              }
            else if (years < 100)
              {
                HarshDays = years / 4;
              }
          else if (years >=500)
              {
                HarshDays = years / 4 - years/100 + years/500;
              }
              var days = (uint)(years) * (uint)(365) + HarshDays;
              var hours = days * 24;
              var minutes = (ulong)(hours) * (ulong)(60);
              var seconds = minutes * 60;
              var milliseconds = seconds * (1000);
              var microseconds = milliseconds * 1000;
              double nanoseconds = (double)(microseconds) * 1000;
              Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8:f0} nanoseconds",centuries,years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);
        }
    }
}