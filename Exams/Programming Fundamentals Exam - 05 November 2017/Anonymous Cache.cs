using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class dataSet
    {
        public string dataSetName { get; set; }
        public string dataKey { get; set; }
        public long dataSize { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dataSets = new List<dataSet>();
            var cacheSets = new List<dataSet>();
            var chosenDataSets = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "thetinggoesskrra") break;

                var tokens = input.Split(new char[] { '-', '>', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens.Length == 1) chosenDataSets.Add(tokens[0]);

                else
                {
                    var dataKey = tokens[0];
                    var dataSize = long.Parse(tokens[1]);
                    var dataSetName = tokens[2];

                    var dataSet = new dataSet();
                    {
                        dataSet.dataSetName = dataSetName;
                        dataSet.dataKey = dataKey;
                        dataSet.dataSize = dataSize;
                    }

                    if (!chosenDataSets.Contains(dataSetName))
                    {
                        cacheSets.Add(dataSet);
                    }

                    else dataSets.Add(dataSet);
                }
            }

            foreach (dataSet cacheSet in cacheSets)
            {
                if (chosenDataSets.Contains(cacheSet.dataSetName))
                {
                    dataSets.Add(cacheSet);
                }
            }
            long max = 0;

            string maxDataSetName = string.Empty;

            if (dataSets.Count > 0)
            {
                foreach (string chosenDataSet in chosenDataSets)
                {
                    long current = dataSets.Where(x => x.dataSetName == chosenDataSet).Select(x => x.dataSize).Sum();
                    if (current > max)
                    {
                        max = current;
                        maxDataSetName = chosenDataSet;
                    }
                }

                Console.WriteLine("Data Set: {0}, Total Size: {1}", maxDataSetName, max);

                var theMax = dataSets.Where(x => x.dataSetName == maxDataSetName);

                foreach (var dataSet in theMax)
                {
                    Console.WriteLine("$.{0}", dataSet.dataKey);
                }
            }
        }
    }
}