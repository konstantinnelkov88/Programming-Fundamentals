using System;
using System.Linq;
class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        string input = Console.ReadLine();
       
        for (int j = 0; j < input.Length; j++)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (input[j].ToString().Contains(alphabet[i]))
                {
                    Console.WriteLine("{0} -> {1}", input[j], i);
                }
            }
        }
    }
}