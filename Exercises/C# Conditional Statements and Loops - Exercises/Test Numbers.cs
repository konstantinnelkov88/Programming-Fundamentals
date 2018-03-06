using System;

class TestNumbers
{
    static void Main(string[] args)
    {
        int n = byte.Parse(Console.ReadLine());
        int m = byte.Parse(Console.ReadLine());
        int maxSum = int.Parse(Console.ReadLine());
        int totalSum = 0;
        int count = 0;

        for (int i = n; i > 0; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                if (totalSum > maxSum) break;
                totalSum += (i * j) * 3;
                count++;
            }
        }
        if (totalSum >= maxSum)
        {
            Console.WriteLine("{0} combinations", count);
            Console.WriteLine("Sum: {0} >= {1}", totalSum, maxSum);
        }
        else
        {
            Console.WriteLine("{0} combinations", count);
            Console.WriteLine("Sum: {0}", totalSum);
        }
    }
}