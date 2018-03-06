using System;

class CakeIngredients
{
    static void Main(string[] args)
    {
        int count = 0;
        while(true)
        {
            string ingredient = Console.ReadLine();
            if (ingredient == "Bake!") break;
            count++;
            Console.WriteLine("Adding ingredient {0}.", ingredient);
        }

        Console.WriteLine("Preparing cake with {0} ingredients.", count);
    }
}