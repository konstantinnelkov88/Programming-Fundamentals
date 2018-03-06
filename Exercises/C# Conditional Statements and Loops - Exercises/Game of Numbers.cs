using System;

class GameOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicalNumber = int.Parse(Console.ReadLine());
        int count = 0;
        int magicI = 0;
        int magicJ = 0;
        bool found = false;

        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                if (i + j == magicalNumber)
                {
                    magicI = i;
                    magicJ = j;
                    found = true;
                }
                count++;
            }
        }

        if (found) Console.WriteLine("Number found! {0} + {1} = {2}", magicI, magicJ, magicI + magicJ);
        else Console.WriteLine("{0} combinations - neither equals {1} ", count, magicalNumber);

    }
}