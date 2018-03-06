using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            for (int i = 0; i < Math.Min(arr1.Length,arr2.Length); i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    break;
                }
                    
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    break;
                } 
                
                if (i == Math.Min(arr1.Length, arr2.Length) - 1)
                {
                   
                   if (arr2.Length > arr1.Length) 
                   {
                       Console.WriteLine(string.Join("", arr1));
                       Console.WriteLine(string.Join("", arr2));
                   }
                       
                   else if (arr2.Length < arr1.Length) 
                       
                   {
                       Console.WriteLine(string.Join("", arr2));
                       Console.WriteLine(string.Join("", arr1));
                   }

                   else
                   {
                       Console.WriteLine(string.Join("", arr2));
                       Console.WriteLine(string.Join("", arr1));
                   }
                }
            }
           
        }
    }
}