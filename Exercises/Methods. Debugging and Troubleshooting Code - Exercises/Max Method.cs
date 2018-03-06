using System;

namespace MaxMethod
{
    class MaxMethod
    {

        static int GetMax(int a, int b)
        {
            if (a > b) { return a; }
            else 
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            if (GetMax(n, m) > k)
            {
                Console.WriteLine(GetMax(n,m));
            }
            else
            {
                Console.WriteLine(k);
            }
         
        }
    }
}