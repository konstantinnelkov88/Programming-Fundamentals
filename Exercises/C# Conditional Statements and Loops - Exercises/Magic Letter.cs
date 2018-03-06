using System;

class MagicLetter
{
    static void Main(string[] args)
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());

        for (char i = a; i <= b; i++)
        {
            if (i == c) continue;
            for (char j = a; j <= b; j++)
            {
                if (j == c) continue;
                for (char k = a; k <= b; k++)
                {
                    if (k == c) continue;
                    Console.Write("{0}{1}{2} ", i,j,k);
                }
            }
        }
        Console.WriteLine();

    }
}