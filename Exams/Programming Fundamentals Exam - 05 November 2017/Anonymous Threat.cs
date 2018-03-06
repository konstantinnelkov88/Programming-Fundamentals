using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            string result = string.Empty;
			
            while (true)
            {
                var taken = Console.ReadLine();

                if (taken == "3:1")
                {
                    break;
                }

                var commandLine = taken.Split(' ').ToArray();
                var command = commandLine[0];

                if (command == "merge")
                {
                    var startIndex = int.Parse(commandLine[1]);
                    var endIndex = int.Parse(commandLine[2]);

                    endIndex = endIndex > input.Count - 1 ? input.Count - 1 : endIndex;
                    startIndex = startIndex > input.Count - 1 ? input.Count - 1 : startIndex;
                    endIndex = endIndex < 0 ? 0 : endIndex;
                    startIndex = startIndex < 0 ? 0 : startIndex;

                    for (int i = 0; i < endIndex - startIndex; i++)
                    {
                        input[startIndex] = input[startIndex] + input[startIndex + 1];
                        input.RemoveAt(startIndex + 1);
                    }
                }
                else
                {
                    var index = int.Parse(commandLine[1]);
                    var partitions = int.Parse(commandLine[2]);
                    var addList = new List<string>();

                    var temp = string.Empty;

                    List<string> groups = (from Match m in Regex.Matches(input[index], @"\\d{4}")
                                           select m.Value).ToList();

                    int times = input[index].Length / partitions;
                    int rest = input[index].Length % partitions;
                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            temp = input[index].Substring(times * i, times + rest);
                        }
                        else
                        {
                            temp = input[index].Substring(times * i, times);
                        }

                        addList.Add(temp);
                    }

                    input.RemoveAt(index);
                    input.InsertRange(index, addList);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}