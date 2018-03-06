using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] newnums = new int[nums.Length / 2];
            int[] newnums1 = new int[nums.Length / 4];
            int[] newnums2 = new int[nums.Length / 4];
            int[] result = new int[newnums.Length];

            for (int i = 0; i < nums.Length / 4; i++)
            {
                newnums1[i] = nums[i];
            }
            Array.Reverse(newnums1);

            for (int i = 0; i < nums.Length / 4; i++)
            {
                newnums2[i] = nums[nums.Length - i - 1];
            }

            newnums = newnums1.Concat(newnums2).ToArray();

            int count = nums.Length / 4;

            for (int i = 0; i < count; i++)
            {
                int first = Array.IndexOf(nums, nums.First());
                int last = Array.IndexOf(nums, nums.Last());
                nums = nums.Take(first).Concat(nums.Skip(first + 1)).ToArray();
                Array.Resize(ref nums, nums.Length - 1);
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums[i] + newnums[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}