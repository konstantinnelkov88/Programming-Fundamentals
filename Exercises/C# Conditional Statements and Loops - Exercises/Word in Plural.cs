using System;

class WordInPlural
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        if (word[word.Length - 1] == 'y')
        {
            word = word.Remove(word.Length - 1);
            word = word + "ies";
        }
        else if (word[word.Length - 1] == 'y' || word[word.Length - 1] == 'o'
                 || word[word.Length - 1] == 's' || word[word.Length - 1] == 'x'
                 || word[word.Length - 1] == 'z')
        {
            word = word + "es";
        }
        else if ((word[word.Length - 2] == 'c' || word[word.Length - 2] == 's') && word[word.Length - 1] == 'h')
        {
            word = word + "es";
        }
        else
        {
            word = word + "s";
        }
        Console.WriteLine(word);
    }
}