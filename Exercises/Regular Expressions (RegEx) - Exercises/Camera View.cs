using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(?<=[|][<])\w+";

            var token = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int m = token[0];

            int n = token[1];

            var input = Console.ReadLine();
            List<string> result = new List<string>();

            MatchCollection cameras = Regex.Matches(input, regex);

            foreach (Match camera in cameras)
            {
                if (camera.Value.Length >= m)
                {
                    int length = camera.Value.Length - m >= n ? n : camera.Value.Length - m;

                    string substr = camera.Value.Substring(m, length);

                    result.Add(substr);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}