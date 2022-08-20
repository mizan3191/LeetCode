using System;

namespace _1470_Shuffle_the_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[] { 2, 5, 1, 3, 4, 7 };
            Shuffle(result, 3);
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            var lnt = nums.Length;
            int[] result = new int[lnt];

            var count=0;

            for (var i =0; i< lnt/2; i++)
            {
                result[i+count] = nums[i];
                result[i +count+ 1] = nums[lnt / 2 + i];
                count++;
            }

            return result;
        }
    }
}
