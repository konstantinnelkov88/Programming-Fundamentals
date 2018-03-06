using System;

class NeighbourWars
{
    static void Main(string[] args)
    {
        int PeshoDamage = int.Parse(Console.ReadLine());
        int GoshoDamage = int.Parse(Console.ReadLine());
        int count = 0;
        int PeshoHealth = 100;
        int GoshoHealth = 100;

        while (true)
        {
            count++;
            if (count % 2 == 1)
            {
                GoshoHealth = GoshoHealth - PeshoDamage;
                if (GoshoHealth <= 0)
                {
                    Console.WriteLine("Pesho won in {0}th round.", count);
                    break;
                }
                Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GoshoHealth);
            }
            else
            {
                PeshoHealth = PeshoHealth - GoshoDamage;
                if (PeshoHealth <= 0)
                {
                    Console.WriteLine("Gosho won in {0}th round.", count);
                    break;
                }
                Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PeshoHealth);
            }
            if (count % 3 == 0)
            {
                GoshoHealth += 10;
                PeshoHealth += 10;
            }
        }
    }
}