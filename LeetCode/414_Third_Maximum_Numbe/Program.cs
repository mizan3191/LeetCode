using System;

namespace _414_Third_Maximum_Numbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1 };
            Console.WriteLine(ThirdMax(nums));
        }

        public static int ThirdMax(int[] nums)
        {
            var max1 = 0;

            for(var i = 0; i<nums.Length; i++)
            {
                if(nums[i] > max1)
                {
                    max1 = nums[i];
                }
            }

            var max2 = 0;
            for(var i = 0; i<nums.Length; i++)
            {
                if(nums[i] > max2 )
                {
                    max1 = nums[i];
                }
            }

            return 0;
        }
    }
}
