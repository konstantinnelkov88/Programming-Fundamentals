using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
                sb.AppendFormat("\\u{0:X4}",(uint)c);
            
            var result = sb.ToString().ToLower();

            Console.WriteLine(result);
        }
    }
}