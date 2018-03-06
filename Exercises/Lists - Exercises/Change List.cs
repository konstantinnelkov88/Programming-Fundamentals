using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Odd" || input == "Even")
                {
                    switch (input)
                    {
                        case "Even":
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if(numbers[i] % 2 == 0) Console.Write("{0} ", numbers[i]);
                            }
                            break;
                        }
                        case "Odd":
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] % 2 == 1) Console.Write("{0} ", numbers[i]);
                            }
                            break;
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    var command = input.Split(' ').ToArray();
                    switch (command[0])
                    {
                        case "Delete":
                        {
                            numbers = Delete(numbers, int.Parse(command[1]));
                            break;
                        }
                        case "Insert":
                        {
                            numbers = Insert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                            break;
                        }
                    }
                }
            }
        }

        public static List<int> Insert(List<int> numbers, int element, int postion)
        {
            numbers.Insert(postion, element);
            return numbers;
        }

        public static List<int> Delete(List<int> numbers, int p)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == p) numbers.Remove(numbers[i]);
            }
            return numbers;
        }
    }
}