using System;

namespace _1929_Concatenation_of_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 1 };
            Program.GetConcatenation(nums);
        }

        public static int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length * 2];

            for(var i = 0; i<nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + nums.Length] = nums[i];
            }

            return result;

        }
    }
}
