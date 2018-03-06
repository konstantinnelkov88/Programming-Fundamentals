using System;

class CountTheIntegers
{
    static void Main(string[] args)
    {
       int count = 0;
       while(true)
       {
           try
           {
               int number = int.Parse(Console.ReadLine());
               count++;
           }
           catch
           {
               break;
           }
       }
       Console.WriteLine(count);
    }
}