using System;

class IntervalofNumbers
{
    static void Main(string[] args)
    {
        var n1 = int.Parse(Console.ReadLine());
        var n2 = int.Parse(Console.ReadLine());

        for (int i = Math.Min(n1,n2); i <= Math.Max(n1,n2); i++)
        {
            Console.WriteLine(i);
        }
    }
}