using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "print")
                {
                    break;
                }

                var parsed = input.Split(' ').ToArray();
                switch (parsed[0])
                {
                    case "add":
                    {
                        int addIndex = int.Parse(parsed[1]);
                        int addelement = int.Parse(parsed[2]);
                        numbers = addNumbers(addIndex, addelement, numbers);
                        break;
                    }

                    case "addMany":
                    {
                        List<int> addedNumbers = new List<int>();
                        int addManyIndex = int.Parse(parsed[1]);
                        for (int i = 2; i < parsed.Length; i++)
                        {
                            addedNumbers.Add(int.Parse(parsed[i]));
                        }
                        numbers = addMany(addManyIndex, addedNumbers, numbers);
                        break;
                    }

                    case "contains":
                    {
                        int containElement = int.Parse(parsed[1]);
                        int index = containNumber(containElement, numbers);
                        Console.WriteLine(index);
                        break;
                    }
                        
                    case "remove":
                        int removeIndex = int.Parse(parsed[1]);
                        numbers = remove(removeIndex, numbers);
                        break;

                    case "shift":
                        int position = int.Parse(parsed[1]);
                        numbers = shift(position, numbers);
                        break;

                    case "sumPairs":
                        numbers = sumPairs(numbers);
                        break;
                }
            }

            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("]");
        }

       static List<int> sumPairs(List<int> numbers)
        {
            List<int> newList = new List<int>();
            int n = 0;

            if (numbers.Count % 2 == 0)
            {
                n = numbers.Count;
            }
            else
            {
                n = numbers.Count - 1;
            }

            for (int i = 0; i < n; i+=2)
            {
                int sumPair = numbers[i] + numbers[i + 1];
                newList.Add(sumPair);
            }
            if (numbers.Count % 2 == 1)
            {
                newList.Add(numbers.Last());
            }
            return newList;
        }


         static List<int> addMany(int addManyIndex, List<int> addedNumbers, List<int> numbers)
        {
            numbers.InsertRange(addManyIndex,addedNumbers);
            return numbers;
        }

         static List<int> shift(int position, List<int> numbers)
         {
             
             for (int i = 0; i < position; i++)
             {
                 numbers.Add(numbers[0]);
                 numbers.RemoveAt(0);
             }
             
             return numbers;
         }

         static List<int> remove(int removeIndex, List<int> numbers)
         {
             numbers.RemoveAt(removeIndex);
             return numbers;
         }

         static int containNumber(int element, List<int> numbers)
         {

             bool found = numbers.Contains(element);

             if (found)
             {
                 int index = numbers.IndexOf(element);
                 return index;
             }
             else
             {
                 return -1;
             }
         }

        static List<int> addNumbers(int addIndex, int element, List<int> numbers)
        {
            numbers.Insert(addIndex,element);
            return numbers;
        }
    }
}