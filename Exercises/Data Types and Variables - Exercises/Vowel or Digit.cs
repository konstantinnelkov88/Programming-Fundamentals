using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)

        {
            char a = char.Parse(Console.ReadLine());

            if(a == 65 || a == 97 || a == 69 || a == 101  || a == 73 || a == 105 || a == 79 || a == 111 || a == 85 || a == 117)
            {
                Console.WriteLine("vowel");
            }
            else if(a >=48 && a<=57)

            {
                   for (int i = 48; i <= 57; i++)
                      {
                           if (a == i)
                         {
                              Console.WriteLine("digit");
                          }
                      }
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}